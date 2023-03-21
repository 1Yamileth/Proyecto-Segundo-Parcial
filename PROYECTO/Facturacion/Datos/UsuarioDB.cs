using Entidades;//REFEENCIA HACIA LAS CLASES DE EL PROYECTO 
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Org.BouncyCastle.Crypto.Tls;

namespace Datos
{
    public class UsuarioDB
    {
        //CADENA DE CONEXION HACIA ELL SERVIDOR
        string cadena = "server=localhost; user= root; database=proyectofactura; password=Cinemax_tNt89";

        //METODOS QUE NOS AYUDAN A INTERACTRUAR CON LA TABLA
        /*DEVOLVEMOS UNA OBJETO DE LA CLASE USUARIO*/
        public Usuario Autenticar(Login login)//RESIVE UN OBEJTO DE LA CLASE LOGIN Y DEVOLVEMOS UN OBJETO DE LA CLASE USUARIO
        {
            Usuario user = null;//Si surge algun error devolvera algun error, debido a los datos son erroneos

            //Evitamos un cierre ineperado con el try
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/
               
                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario=@CodigoUsuario AND Contrasena= @Contrasena");/*EVOLVERA LOS USUARIOS DE LA TABLA, en nuestro caso solo queremos asber ciertas cosas
                                                                                                                    con en "where" haremos que solo nos pase los espacios que queremos*/
               
                /*EL USING ENCAPSULA TODO EL CODIGO DENTRO DE EL, SI NO LO PONDEMOS TENDRIAMOS QUE PONER UN CLOSE A LA CONEXION*/
                using (MySqlConnection _conexion = new MySqlConnection(cadena))/*NOS AYUDA A QUE AL SALIR DE LA OPERACION 
                                                                               * CON LA DB, ESTA LA CIERRA AUTOMATICAMENTE.
                                                                                  A LA CLASE DE "MYSQLCONNECTION, LE PASAMOS COMO APRAEMTRO LA CADENA DE CONEXION HACIA LA DB*/
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar,50).Value= login.CodigoUsuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader();/*EL DAATAREEADE captura todos los registros que ingrese el usuario*/
                        
                        if (dr.Read())/*VALIDAMOS SI EL DATA  READER TIENE ALGO */
                        {
                            user = new Usuario();//INSTANCIADO EL OBJETO USER

                            /*en los corchetes ponemos los nombres de los campos que pasaremos tal cual esta en la DB*/
                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Contrasena"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.EstadoActivo = Convert.ToBoolean(dr["EstadoActivo"]);
                            if (dr["Fotografia"].GetType()!= typeof(DBNull)) //BDNull= campo nulo de BD
                            {
                                user.Foto = (byte[])dr["Foto"];
                            }

                        }
                    }
                } 

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {
                              
            }





            return user;
        }

        public bool Insertar(Usuario user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();//Clase para sentencias SQL

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("INSERT INTO usuario VALUES ");
                sql.Append("( @CodigoUsuario, @Nombre, @Contrasena, @Correo, @Rol, @Fotografia, @FechaCreacion, @EstadoActivo); ");//Pasando parametros y estos tienen que ir en el orden de las BD
                
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Fotografia", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = user.FechaCreacion;
                        comando.Parameters.Add("@EstadoActivo", MySqlDbType.Bit).Value = user.EstadoActivo;
                        comando.ExecuteNonQuery();//Ejecutaremos pero no devolveremos nignun registro.
                        inserto = true;
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }

            return inserto;
        }

        public bool EditarUsuario(Usuario user)
        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("UPDATE usuario SET ");                                                                                    
                sql.Append("Nombre = @Nombre, Contrasena = @Contrasena, Correo = @Correo, Rol = @Rol, Fotografia = @Fotografia, EstadoActivo = @EstadoActivo ");
                sql.Append("WHERE CodigoUsuario= @CodigoUsuario; ");//Con este campo sabemos cual usuario es el que modificaremos, sino se modificarian todos los otros.

               
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Fotografia", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@EstadoActivo", MySqlDbType.Bit).Value = user.EstadoActivo;
                        comando.ExecuteNonQuery();//Ejecutaremos pero no devolveremos nignun registro.
                        edito = true;
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }

            return edito;
        }

        public bool Eliminar(string codigoUsuario)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("DELETE FROM usuario  ");
                sql.Append("WHERE CodigoUsuario= @CodigoUsuario;");//Con este campo sabemos cual usuario es el que modificaremos, sino se modificarian todos los otros.


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        comando.ExecuteNonQuery();//Ejecutaremos pero no devolveremos nignun registro.
                        elimino = true;
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }

            return elimino;
        }

        public DataTable DevolverUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("SELECT * FROM usuario  ");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;
                        //Ocupamos el datareader porque estamos extrayendo datos,
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);//Le estamos pasando los datos guardados en el dr al dt.
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }

            return dt;
        }

        public byte[] DevolverFoto(string codigoUsuario)
        {
            byte[] foto = new byte[0];//arreglo de byte
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                sql.Append("SELECT Fotografia FROM usuario WHERE CodigoUsuario= @CodigoUsuario ");//Estamos consultando la foto de un usuario en especifico, por eso va en "where" seguido del "CodigoUsuario"


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        //Ocupamos el datareader porque estamos extrayendo datos,
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            foto = (byte[])dr["Fotografia"];//Le pasamos a el arreglo de byte la foto almacenada
                        }
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }
            return foto;
        }

    }
}
