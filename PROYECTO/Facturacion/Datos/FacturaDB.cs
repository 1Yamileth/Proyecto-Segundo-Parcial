using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FacturaDB
    {
        string cadena = "server=localhost; user= root; database=proyectofactura; password=Cinemax_tNt89";
         //FALLA
        public bool GuardarFactura(Factura factura, List<DetalleFactura> detalles )//PASAMOS UNA LISTA DE DETALLE AL LIST
        {
            bool inserto = false;
            int IdFactura = 0;
            try
            {
                StringBuilder sqlFactura= new StringBuilder();//Sentencia para guardar la factura
                sqlFactura.Append("INSERT INTO factura (FechaFactura, IdentidadCliente, CodigoUsuario, ISV, Descuento, Subtotal, Total) VALUES (@FechaFactura, @IdentidadCliente, @CodigoUsuario, @ISV, @Descuento, @Subtotal, @Total);");
                sqlFactura.Append("SELECT LAST_INSERT_ID();");// LAST_INSERT_ID(), nos devuelve el ultimo id o FK de la table que acabamos de insertar


                //Lo usamos para guardar el detalle de la factura
                StringBuilder sqlDetalle= new StringBuilder();
                sqlDetalle.Append("INSERT INTO detallefactura (IdFactura, CodigoProducto, Precio, Cantidad, Total) VALUES (@IdFactura, @CodigoProducto, @Precio, @Cantidad, @Total);");
                
                //Se ocupa para restar la existencia en la BD dependiendo cuantos productos lleva el cliente y si el codigo del poducto es el  indicado.
                StringBuilder sqlExistencia = new StringBuilder();
                sqlExistencia.Append("UPDATE producto SET Existencia = Existencia - @Cantidad WHERE CodigoProducto = @CodigoProducto;");


                using (MySqlConnection con = new MySqlConnection(cadena)) 
                {
                   con.Open();
                    MySqlTransaction transaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);/*Lo que hace la transaccion es que se hace un backup si sucede algun error de conexion
                                                                                                                   * IsoletionLevel y READ COMMITTED, bloquean las tablas, pero deja leer la tabla para los demas usuarios.*/
                     
                    try
                    {
                        using (MySqlCommand cmd1 = new MySqlCommand(sqlFactura.ToString(), con, transaction))//Le pasamos la sentencia sql y el objeto de trasaccines
                        {//PASAMOS LOS PARAMETROS DE LA FACTURA
                            cmd1.CommandType = System.Data.CommandType.Text; 
                            cmd1.Parameters.Add("@FechaFactura", MySqlDbType.DateTime).Value = factura.FechaFactura;
                            cmd1.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar,25).Value = factura.IdentidadCliento;
                            cmd1.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = factura.CodigoUsuario;
                            cmd1.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = factura.ISV;
                            cmd1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = factura.Descuento;
                            cmd1.Parameters.Add("@Subtotal", MySqlDbType.Decimal).Value = factura.Subtotal;
                            cmd1.Parameters.Add("@Total", MySqlDbType.Decimal).Value = factura.Total;
                            IdFactura = Convert.ToInt32(cmd1.ExecuteScalar());/*Nos srive para captura el ultimo id que trae la sentencia IDFACTURA
                                                                               * EL ExecureScalar, es quien trae el valor con la sentencia antes definida*/

                            //INSERTANDO DETALLES DE PRODUCTOS
                            foreach (DetalleFactura detalle in detalles)/*Al entrar aca ingresaria los detalles y rebajaria la existencia de los productos*/
                            {
                                using (MySqlCommand cmd2 = new MySqlCommand(sqlDetalle.ToString(), con, transaction))
                                {
                                    //Pasandole los parametros a la sentencia detalles
                                    cmd2.CommandType = System.Data.CommandType.Text;
                                    cmd2.Parameters.Add("@IdFactura", MySqlDbType.Int32).Value= IdFactura;
                                    cmd2.Parameters.Add("@CodigoProducto", MySqlDbType.VarChar, 50).Value = detalle.CodigoProducto;
                                    cmd2.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = detalle.Precio;
                                    cmd2.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = detalle.Cantidad;
                                    cmd2.Parameters.Add("@Total", MySqlDbType.Decimal).Value = detalle.Total;
                                    cmd2.ExecuteNonQuery();//Es para que no devolvamos nada, sino que solo insertemos detalles

                                }
                                using (MySqlCommand cmd3 = new MySqlCommand(sqlExistencia.ToString(), con, transaction))
                                {
                                    cmd3.CommandType = System.Data.CommandType.Text;
                                    cmd3.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = detalle.Cantidad;
                                    cmd3.Parameters.Add("@CodigoProducto", MySqlDbType.VarChar, 80).Value = detalle.CodigoProducto;
                                    cmd3.ExecuteNonQuery();

                                }
                            }
                            transaction.Commit();//Ejecutara la transaccion y si llega hasta aca sera true
                            inserto = true;
                        }
                    }
                    catch (Exception)
                    {
                        inserto = false;
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception)
            {
            }
            return inserto;
        }
    }
}
