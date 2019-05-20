using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administracion.Entidades;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Administracion.Datos
{
    public class DAODetalleOrden
    {

        string _cadenaConexion;

        public string CadenaConexion
        {
            get
            {
                if (_cadenaConexion == null)
                {
                    _cadenaConexion = ConfigurationManager.
                        ConnectionStrings["Conex"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set { _cadenaConexion = value; }
        }

        public List<DetalleOrden> Listar(int IdOrden)
        {
            List<DetalleOrden> lista = new List<DetalleOrden>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerOrdenCompraPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", IdOrden);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DetalleOrden c = new DetalleOrden(
                                    (int)dr["idOrdenCompra"],
                                    (long)dr["totalOrdenCompra"],
                                    (DateTime)dr["fechaCompraOrden"],
                                    (DateTime)dr["fechaPagoOrden"],
                                    (int)dr["nroIdPersona"],
                                    (string)dr["nombrePersona"],
                                    (string)dr["direccionPersona"],
                                    (long)dr["celularPersona"],
                                    (string)dr["emailPersona"],
                                    (int)dr["idDetalleCompra"],
                                    (decimal)dr["valorProducto"],                                    
                                    (long)dr["subtotalDetalle"],
                                    (int)dr["cantidadDetalle"],
                                    (string)dr["NombreProducto"]);

                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

    }
}
