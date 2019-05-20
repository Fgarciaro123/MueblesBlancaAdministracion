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
    public class DAOOrdenCompra
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

        public List<OrdenCompra> Listar()
        {
            List<OrdenCompra> lista = new List<OrdenCompra>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarOrdenCompra", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        OrdenCompra c = new OrdenCompra((int)dr["IdOrdenCompra"],
                            (int)dr["IdPersonaOrdenCompra"],
                            (DateTime)dr["FechaCompra"],
                            (long)dr["TotalCompra"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        public OrdenCompra TraerOrdenCompraPorId(int Id)
        {
            OrdenCompra ordenCompra = new OrdenCompra();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerOrdenCompraPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    OrdenCompra c = new OrdenCompra((int)dr["IdOrdenCompra"],
                                           (int)dr["IdPersonaOrdenCompra"],
                                           (DateTime)dr["FechaCompra"],
                                           (long)dr["TotalCompra"]);
                }
            }
            return ordenCompra;
        }




    }
}
