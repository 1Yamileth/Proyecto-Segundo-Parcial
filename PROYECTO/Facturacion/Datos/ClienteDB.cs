using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDB
    {
        //CADENA DE CONEXION HACIA ELL SERVIDOR
        string cadena = "server=localhost; user= root; database=proyectofactura; password=Cinemax_tNt89";
        public bool InsertarCliente(Cliente cliente)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();//Clase para sentencias SQL

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("INSERT INTO cliente VALUES ");
                sql.Append("( @IdentidadCliente, @Nombre, @Telefono, @Correo, @Direccion, @FechaNacimiento, @EstaActivo); ");//Pasando parametros y estos tienen que ir en el orden de las BD

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = cliente.IdentidadCliente;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = cliente.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 20).Value = cliente.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = cliente.FechaNacimiento;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = cliente.EstaActivo;

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
        public bool EditarCliente(Cliente cliente)
        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("UPDATE cliente SET ");//NOMBRE DE LA TABLA
                sql.Append("Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, FechaNacimiento = @FechaNacimiento, EstaActivo = @EstaActivo ");
                sql.Append("WHERE IdentidadCliente= @IdentidadCliente; ");//Con este campo sabemos cual usuario es el que modificaremos, sino se modificarian todos los otros.


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = cliente.IdentidadCliente;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = cliente.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 20).Value = cliente.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = cliente.FechaNacimiento;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = cliente.EstaActivo;
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
        public bool Eliminar(string identidadCliente)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("DELETE FROM cliente  ");
                sql.Append("WHERE IdentidadCliente= @IdentidadCliente;");//Con este campo sabemos cual usuario es el que modificaremos, sino se modificarian todos los otros.


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 15).Value = identidadCliente;
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
        public DataTable DevolverClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("SELECT * FROM cliente  ");


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

       public Cliente DevolverClientePorId(string identidadCliente)
        {//LO USAMOS EN LA FACTURA
            Cliente clien = null;
           
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("SELECT * FROM cliente WHERE IdentidadCliente=@IdentidadCliente  ");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = identidadCliente;
                       //Ocupamos el datareader porque estamos extrayendo datos,
                        MySqlDataReader dr = comando.ExecuteReader();
                       if (dr.Read())
                       {
                            clien = new Cliente();
                            clien.IdentidadCliente = identidadCliente;
                            clien.Nombre = dr["Nombre"].ToString();
                            clien.Telefono = dr["Telefono"].ToString();
                            clien.Correo = dr["Correo"].ToString();
                            clien.Direccion = dr["Direccion"].ToString();
                            clien.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                            clien.EstaActivo = Convert.ToBoolean( dr["EstaActivo"]);
                        }
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }

            return clien;
        }

        public DataTable DevolverClientesPorNombres(string Nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
     /*FALLA*/ sql.Append("SELECT * FROM cliente WHERE Nombre LIKE '%"+ Nombre +"%'");//Lo hacemos de esta manera para que al momento de buscar el nombre salga todo lo qe esta dentro de los comodines


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value= Nombre;
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

    }
}
