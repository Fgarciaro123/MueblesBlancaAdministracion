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
    public class DAOPersona
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

        public List<Persona> Listar()
        {
            List<Persona> lista = new List<Persona>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarPersona", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Persona c = new Persona(
                            (int)dr["IdPersona"],
                            (long)dr["NumeroIdentificacionPersona"],
                            (int)dr["IdTipoDocumentoPersona"],
                            (string)dr["PrimerNombrePersona"],
                            (string)dr["SegundoNombrePersona"],
                            (string)dr["PrimerApellidoPersona"],
                            (string)dr["SegundoApellidoPersona"],
                            (string)dr["EmailPersona"],
                            (int)dr["CelularPersona"],
                            (string)dr["DireccionPersona"],
                            (int)dr["IdRolPersona"],
                            (string)dr["PasswordPersona"],
                            (DateTime)dr["FechaCreacionPersona"],
                            (DateTime)dr["FechaModificacionPersona"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }
        public Persona TraerPorId(int Id)
        {
            Persona persona = new Persona();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerPersonaPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Persona c = new Persona(
                        (int)dr["IdPersona"],
                        (long)dr["NumeroIdentificacionPersona"],
                        (int)dr["IdTipoDocumentoPersona"],
                        (string)dr["PrimerNombrePersona"],
                        (string)dr["SegundoNombrePersona"],
                        (string)dr["PrimerApellidoPersona"],
                        (string)dr["SegundoApellidoPersona"],
                        (string)dr["EmailPersona"],
                        (int)dr["CelularPersona"],
                        (string)dr["DireccionPersona"],
                        (int)dr["IdRolPersona"],
                        (string)dr["PasswordPersona"],
                        (DateTime)dr["FechaCreacionPersona"],
                        (DateTime)dr["FechaModificacionPersona"]);
                }
            }
            return persona;
        }

        public int Insertar(Persona persona)
        {// IdCliente, NroDocumento, Nombre, Direccion, Telefono, Observacion
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarPersona", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroIdentificacionPersona", persona.NumeroIdentificacionPersona);
                cmd.Parameters.AddWithValue("@TipoDocumento", persona.TipoDocumento);
                cmd.Parameters.AddWithValue("@PrimerNombre", persona.PrimerNombre);
                cmd.Parameters.AddWithValue("@SegundoNombre", persona.SegundoNombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", persona.PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", persona.SegundoApellido);
                cmd.Parameters.AddWithValue("@Email", persona.Email);
                cmd.Parameters.AddWithValue("@RolPersona", persona.RolPersona);
                cmd.Parameters.AddWithValue("@Password", persona.Password);
                cmd.Parameters.AddWithValue("@FechaCreacion", persona.FechaCreacion);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        //public int Actualizar(Usuario usuario)
        //{
        //    int n = -1;
        //    using (SqlConnection con = new SqlConnection(CadenaConexion))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("ActualizarUsuario", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Id", usuario.IdUsuario);
        //        cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
        //        cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
        //        cmd.Parameters.AddWithValue("@Login", usuario.Login);
        //        cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
        //        cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
        //        cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
        //        n = cmd.ExecuteNonQuery();
        //    }
        //    return n;
        //}

        public int Eliminar(int Id)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarPersona", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public Boolean TraerPorPersonaClave(string var_usu, string var_clave)
        {
            Persona persona = new Persona();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerPorPersonaClave", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usu", var_usu);
                cmd.Parameters.AddWithValue("@clave", var_clave);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    return true;

                    //Persona c = new Persona(
                    //    (int)dr["IdPersona"],
                    //    (long)dr["NumeroIdentificacionPersona"],
                    //    (int)dr["IdTipoDocumentoPersona"],
                    //    (string)dr["PrimerNombrePersona"],
                    //    (string)dr["SegundoNombrePersona"],
                    //    (string)dr["PrimerApellidoPersona"],
                    //    (string)dr["SegundoApellidoPersona"],
                    //    (string)dr["EmailPersona"],
                    //    (int)dr["CelularPersona"],
                    //    (string)dr["DireccionPersona"],
                    //    (int)dr["IdRolPersona"],
                    //    (string)dr["PasswordPersona"],
                    //    (DateTime)dr["FechaCreacionPersona"],
                    //    (DateTime)dr["FechaModificacionPersona"]);
                }
                else
                {
                    return false;
                }

            }
        }

        public int obtenerIdRolAdministrador()
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ObtenerIdAdministrador", con);
                cmd.CommandType = CommandType.StoredProcedure;
                n = cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    int c = (int)dr["IdRol"];
                }
                return n;
            }

        }

        public Boolean existeAdmin()
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ExisteAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                n = cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


        public Boolean ValidarExistenciaEmail(string email)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ValidarExistenciaEmail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public Boolean ActualizarContraseña(string correo, string clave)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarContraseña", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Clave", clave);
                n = cmd.ExecuteNonQuery();

                if (n > -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
        }   
    }
}
