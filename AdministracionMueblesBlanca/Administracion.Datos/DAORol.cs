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
    public class DAORol
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


        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarRoles", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Rol c = new Rol(
                            (int)dr["IdRol"],
                            (string)dr["NombreRol"],
                            (DateTime)dr["FechaCreacionRol"],
                            (string)dr["UsuarioCreacionRol"],
                            (DateTime)dr["FechaModificacionRol"],
                            (string)dr["UsuarioModificacionRol"],
                            (int)dr["EstadoRol"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        public Rol TraerRolPorId(int Id)
        {
            Rol rol = new Rol();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerRolPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRol", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    rol = new Rol(
                      (int)dr["IdRol"],
                      (string)dr["NombreRol"],
                      (DateTime)dr["FechaCreacionRol"],
                      (string)dr["UsuarioCreacionRol"],
                      (DateTime)dr["FechaModificacionRol"],
                      (string)dr["UsuarioModificacionRol"],
                      (int)dr["EstadoRol"]);
                }
            }
            return rol;
        }

        public int Insertar(Rol rol)
        { 
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarRol", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreRol", rol.NombreRol);
                cmd.Parameters.AddWithValue("@FechaCreacionRol", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioCreacionRol", "PENDIENTE");
                cmd.Parameters.AddWithValue("@EstadoRol", rol.EstadoRol);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        public int Actualizar(Rol rol)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarRol", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRol", rol.IdRol);
                cmd.Parameters.AddWithValue("@NombreRol", rol.NombreRol);
                cmd.Parameters.AddWithValue("@FechaModificacionRol", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioModificacionRol", "PENDIENTE");
                cmd.Parameters.AddWithValue("@EstadoRol", rol.EstadoRol);
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
                SqlCommand cmd = new SqlCommand("EliminarRol", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRol", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }


    }
}
