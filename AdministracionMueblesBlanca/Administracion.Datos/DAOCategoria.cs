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
    public class DAOCategoria
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

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarCategorias", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Categoria c = new Categoria((int)dr["IdCategoria"],
                            (string)dr["NombreCategoria"], (DateTime)dr["FechaCreacionCategoria"],
                            (string)dr["UsuarioCreacionCategoria"], (DateTime)dr["FechaModificacionCategoria"],
                            (string)dr["UsuarioModificacionCategoria"], (int)dr["EstadoCategoria"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        public Categoria TraerPorId(int Id)
        {
            Categoria Categoria = new Categoria();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerCategoriaPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Categoria = new Categoria((int)dr["IdCategoria"],
                            (string)dr["NombreCategoria"], (DateTime)dr["FechaCreacionCategoria"],
                            (string)dr["UsuarioCreacionCategoria"], (DateTime)dr["FechaModificacionCategoria"],
                            (string)dr["UsuarioModificacionCategoria"], (int)dr["EstadoCategoria"]);
                }
            }
            return Categoria;
        }

        public int Insertar(Categoria Categoria)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCategoria", Categoria.IdCategoria);
                cmd.Parameters.AddWithValue("@NombreCategoria", Categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@FechaCreacionCategoria", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioCreacionCategoria", "");
                cmd.Parameters.AddWithValue("@EstadoCategoria", 1);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int Actualizar(Categoria Categoria)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCategoria", Categoria.IdCategoria);
                cmd.Parameters.AddWithValue("@NombreCategoria", Categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@FechaModificacionCategoria", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioModificacionCategoria", "");
                cmd.Parameters.AddWithValue("@EstadoCategoria", Categoria.EstadoCategoria);

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
                SqlCommand cmd = new SqlCommand("EliminarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCategoria", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

    }
}
