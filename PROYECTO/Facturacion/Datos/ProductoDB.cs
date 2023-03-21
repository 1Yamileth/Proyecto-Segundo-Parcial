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
    public class ProductoDB
    {
        //CADENA DE CONEXION HACIA ELL SERVIDOR
        string cadena = "server=localhost; user= root; database=proyectofactura; password=Cinemax_tNt89";


        public bool Insertar(Producto producto)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();//Clase para sentencias SQL

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("INSERT INTO producto VALUES ");
                sql.Append("( @Codigo, @Descripcion, @Existencia, @Precio, @Foto, @EstaActivo); ");//Pasando parametros y estos tienen que ir en el orden de las BD

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.CodigoProducto;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Foto;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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

        public bool Editar(Producto producto)
        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("UPDATE producto SET ");
                sql.Append("Codigo = @Codigo, Descripcion = @Descripcion, Existencia = @Existencia, Precio = @Precio, Foto = @Foto, EstaActivo = @EstaActivo ");
                sql.Append("WHERE Codigo= @Codigo; ");//Con este campo sabemos cual usuario es el que modificaremos, sino se modificarian todos los otros.


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.CodigoProducto;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Foto;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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

        public bool Eliminar(string codigo)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("DELETE FROM producto  ");
                sql.Append("WHERE Codigo= @Codigo;");//Con este campo sabemos cual usuario es el que modificaremos, sino se modificarian todos los otros.


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;

                        //PASANDO LOS PARAMETROS QUE QUEREMOS A LA TABLA, LAS COSAS QUE INGRESEMOS SE VAN A LA BD
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
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

        public DataTable DevolverProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("SELECT * FROM producto  ");


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

        public byte[] DevolverFoto(string codigo)
        {
            byte[] foto = new byte[0];//arreglo de byte
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                sql.Append("SELECT Foto FROM producto WHERE Codigo= @Codigo ");//Estamos consultando la foto de un usuario en especifico, por eso va en "where" seguido del "CodigoUsuario"


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        //Ocupamos el datareader porque estamos extrayendo datos,
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            foto = (byte[])dr["Foto"];//Le pasamos a el arreglo de byte la foto almacenada
                        }
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }
            return foto;
        }

        public Producto DevolverProductoPorCodigo(string Codigo)
        {//LO USAMOS EN LA FACTURA
            Producto product = null;

            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("SELECT * FROM producto WHERE CodigoProducto=@CodigoProducto  ");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoProducto", MySqlDbType.VarChar, 80).Value= Codigo;
                        //Ocupamos el datareader porque estamos extrayendo datos,
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            product = new Producto();
                            product.CodigoProducto = Codigo;
                            product.Descripcion = dr["Descripcion"].ToString();
                            product.Existencia =Convert.ToInt32(dr["Existencia"]);
                            product.Precio = Convert.ToDecimal (dr["Precio"]);
                            product.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                         //   product.Foto = dr["Foto"].ToString();
                        }
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }

            return product;
        }

        public DataTable DevolverProductosPorDescripcion(string descripcion)
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();/*CON ESTA CLASE PODEMOS AGREGAR UNA SENTENCIAL SQL EN VARIAS 
                                                         * LINEAS Y SE VERA ORDENADO*/

                //SENTENCIA PARA INSERTAR REGISTRO EN UNA BD
                sql.Append("SELECT * FROM producto  WHERE Descripcion LIKE '%"+ descripcion + "%'");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();//ABRIENDO LA CONEXION
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))/*LE PASAMOS LA SENTENCIA SQL QUE EJECUTAREMOS Y DE QUE CONEXION SERA*/
                    {
                        //QUE TIPO DE COMANDO EJECUTAREMOS
                        comando.CommandType = CommandType.Text;
                       //comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value= descripcion;
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
