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
    public class DAOModelo
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


        public List<Modelo> Listar(int idProducto)
        {
            List<Modelo> lista = new List<Modelo>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarModelos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProductoModelo", idProducto);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Modelo modelo = new Modelo(
                            (int)dr["IdModelo"],
                            (int)dr["IdProductoModelo"],
                            (string)dr["TituloModelo"],
                            (string)dr["RutaModelo"],
                            (DateTime)dr["FechaCreacionModelo"],
                            (string)dr["UsuarioCreacionModelo"],
                            (DateTime)dr["FechaModificacionModelo"],
                            (string)dr["UsuarioModificacionModelo"],
                            (int)dr["EstadoModelo"]);
                        lista.Add(modelo);
                    }
                }
            }
            return lista;
        }

        public Modelo TraerModeloPorId(int IdModelo, int IdProducto)
        {
            Modelo modelo = new Modelo();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerModeloPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModelo", IdModelo);
                cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    modelo = new Modelo(
                            (int)dr["IdModelo"],
                            (int)dr["IdProductoModelo"],
                            (string)dr["TituloModelo"],
                            (string)dr["RutaModelo"],
                            (DateTime)dr["FechaCreacionModelo"],
                            (string)dr["UsuarioCreacionModelo"],
                            (DateTime)dr["FechaModificacionModelo"],
                            (string)dr["UsuarioModificacionModelo"],
                            (int)dr["EstadoModelo"]);
                }
            }
            return modelo;
        }

        public int Insertar(Modelo modelo)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarModelo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProductoModelo", modelo.IdProductoModelo);
                cmd.Parameters.AddWithValue("@TituloModelo", modelo.TituloModelo);
                cmd.Parameters.AddWithValue("@RutaModelo", modelo.RutaModelo);
                cmd.Parameters.AddWithValue("@FechaCreacionModelo", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioCreacionModelo", modelo.UsuarioCreacionModelo);
                cmd.Parameters.AddWithValue("@EstadoModelo", modelo.EstadoModelo);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        public int Actualizar(Modelo modelo)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarModelo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModelo", modelo.IdModelo);
                cmd.Parameters.AddWithValue("@IdProductoModelo", modelo.IdProductoModelo);
                cmd.Parameters.AddWithValue("@TituloModelo", modelo.TituloModelo);
                cmd.Parameters.AddWithValue("@RutaModelo", modelo.RutaModelo);
                cmd.Parameters.AddWithValue("@FechaModificacionModelo", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioModificacionModelo", sesion.UsuarioSesion);
                cmd.Parameters.AddWithValue("@EstadoModelo", modelo.EstadoModelo);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int Eliminar(int IdModelo, int IdProducto)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarModelo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModelo", IdModelo);
                cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }


    }
}
