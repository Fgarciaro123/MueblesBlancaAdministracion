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
    public class DAOImagen
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

        public List<Imagen> Listar()
        {
            List<Imagen> lista = new List<Imagen>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarImagenes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Imagen imagen = new Imagen(
                            (int)dr["IdImagen"],
                            (int)dr["idProductoImagen"],
                            (string)dr["TituloImagen"],
                            (byte)dr["CodigoImagen"],
                            (DateTime)dr["FechaCreacionImagen"],
                            (string)dr["UsuarioCreacionImagen"],
                            (DateTime)dr["FechaModificacionImagen"],
                            (string)dr["UsuarioModificacionImagen"],
                            (int)dr["EstadoImagen"]);
                        lista.Add(imagen);
                    }
                }
            }
            return lista;
        }

        public Imagen TraerImagenPorId(int Id)
        {
            Imagen imagen = new Imagen();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerImagenPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdImagen", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    imagen = new Imagen(
                        (int)dr["IdImagen"],
                        (int)dr["idProductoImagen"],
                        (string)dr["TituloImagen"],
                        (byte)dr["CodigoImagen"],
                        (DateTime)dr["FechaCreacionImagen"],
                        (string)dr["UsuarioCreacionImagen"],
                        (DateTime)dr["FechaModificacionImagen"],
                        (string)dr["UsuarioModificacionImagen"],
                        (int)dr["EstadoImagen"]);
                }
            }
            return imagen;
        }

        public int Insertar(Imagen imagen)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarImagen", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProductoImagen", imagen.IdProductoImagen);
                cmd.Parameters.AddWithValue("@TituloImagen", imagen.TituloImagen);
                cmd.Parameters.AddWithValue("@CodigoImagen", imagen.CodigoImagen);
                cmd.Parameters.AddWithValue("@FechaCreacionImagen", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioCreacionImagen", "Pendiente");
                cmd.Parameters.AddWithValue("@EstadoImagen", imagen.EstadoImagen);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int Actualizar(Imagen imagen)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarImagen", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdImagen", imagen.IdImagen);
                cmd.Parameters.AddWithValue("@idProductoImagen", imagen.IdProductoImagen);
                cmd.Parameters.AddWithValue("@TituloImagen", imagen.TituloImagen);
                cmd.Parameters.AddWithValue("@CodigoImagen", imagen.CodigoImagen);
                cmd.Parameters.AddWithValue("@FechaModificacionImagen", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioModificacionImagen", "Pendiente 2");
                cmd.Parameters.AddWithValue("@EstadoImagen", imagen.EstadoImagen);

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
                SqlCommand cmd = new SqlCommand("EliminarImagen", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdImagen", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

    }
}
