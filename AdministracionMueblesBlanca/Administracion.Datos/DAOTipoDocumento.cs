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
    public class DAOTipoDocumento
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



        public List<TipoDocumento> Listar()
        {
            List<TipoDocumento> lista = new List<TipoDocumento>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarTiposDocumento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TipoDocumento td = new TipoDocumento((int)dr["IdTipoDocumento"],
                            (string)dr["DescripcionTipoDocumento"],
                            (DateTime)dr["FechaCreacionTipoDocumento"],
                            (string)dr["UsuarioCreacionTipoDocumento"],
                            (DateTime)dr["FechaModificacionTipoDocumento"],
                            (string)dr["UsuarioModificacionTipoDocumento"],
                            (int)dr["EstadoTipoDocumento"]);
                        lista.Add(td);
                    }
                }
            }
            return lista;
        }

        public TipoDocumento TraerPorId(int Id)
        {
            TipoDocumento tipoDocumento = new TipoDocumento();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerTiposDocumentoPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoDocumento", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    tipoDocumento = new TipoDocumento((int)dr["IdTipoDocumento"],
                            (string)dr["DescripcionTipoDocumento"],
                            (DateTime)dr["FechaCreacionTipoDocumento"],
                            (string)dr["UsuarioCreacionTipoDocumento"],
                            (DateTime)dr["FechaModificacionTipoDocumento"],
                            (string)dr["UsuarioModificacionTipoDocumento"],
                            (int)dr["EstadoTipoDocumento"]);
                }
            }
            return tipoDocumento;
        }

        public int Insertar(TipoDocumento tipoDocumento)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarTipoDocumento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DescripcionTipoDocumento", tipoDocumento.DescripcionTipoDocumento);
                cmd.Parameters.AddWithValue("@FechaCreacionTipoDocumento", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioCreacionTipoDocumento", "pendiente");
                cmd.Parameters.AddWithValue("@EstadoTipoDocumento", tipoDocumento.EstadoTipoDocumento);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int Actualizar(TipoDocumento tipoDocumento)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarTipoDocumento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoDocumento", tipoDocumento.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@DescripcionTipoDocumento", tipoDocumento.DescripcionTipoDocumento);
                cmd.Parameters.AddWithValue("@FechaModificacionTipoDocumento", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioModificacionTipoDocumento", "pendiente");
                cmd.Parameters.AddWithValue("@EstadoTipoDocumento", tipoDocumento.EstadoTipoDocumento);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }


        public int Eliminar(int Id)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarTipoDocumento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoDocumento", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

    }
}

