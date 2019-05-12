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
    public class DAOProducto
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


        //Listar Productos

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {

                        Producto p = new Producto(
                            (int)dr["IdProducto"],
                            (string)dr["NombreProducto"],
                            (string)dr["DescripcionProducto"],
                            (string)dr["AltoProducto"],
                            (string)dr["AnchoProducto"],
                            (string)dr["ColorProducto"],
                            (string)dr["MaterialProducto"],
                            (int)dr["GarantiaMesesProducto"],
                            (Decimal)dr["ValorUnitarioProducto"],
                            (int)dr["IdCategoriaProducto"],
                            (DateTime)dr["FechaCreacionProducto"],
                            (string)dr["UsuarioCreacionProducto"],
                            (DateTime)dr["FechaModificacionProducto"],
                            (string)dr["UsuarioModificacionProducto"],
                            (int)dr["EstadoProducto"]);

                        lista.Add(p);
                    }
                }
            }
            return lista;
        }

        //Consultar por Id
        public Producto TraerProductoPorId(int Id)
        {
            Producto producto = new Producto();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerProductoPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    producto = new Producto(
                         (int)dr["IdProducto"],
                         (string)dr["NombreProducto"],
                         (string)dr["DescripcionProducto"],
                         (string)dr["AnchoProducto"],
                         (string)dr["AltoProducto"],
                         (string)dr["ColorProducto"],
                         (string)dr["MaterialProducto"],
                         (int)dr["GarantiaMesesProducto"],
                         (Decimal)dr["ValorUnitarioProducto"],
                         (int)dr["IdCategoriaProducto"],
                         (DateTime)dr["FechaCreacionProducto"],
                         (string)dr["UsuarioCreacionProducto"],
                         (DateTime)dr["FechaModificacionProducto"],
                         (string)dr["UsuarioModificacionProducto"],
                         (int)dr["EstadoProducto"]);
                }
            }
            return producto;
        }

        //Insertar nuevo producto
        public int Insertar(Producto producto)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                cmd.Parameters.AddWithValue("@DescripcionProducto", producto.DescripcionProducto);
                cmd.Parameters.AddWithValue("@AltoProducto", producto.AltoProducto);
                cmd.Parameters.AddWithValue("@AnchoProducto", producto.AnchoProducto);
                cmd.Parameters.AddWithValue("@ColorProducto", producto.ColorProducto);
                cmd.Parameters.AddWithValue("@MaterialProducto", producto.MaterialProducto);
                cmd.Parameters.AddWithValue("@GarantiaMesesProducto", producto.GarantiaMesesProducto);
                cmd.Parameters.AddWithValue("@ValorUnitarioProducto", producto.ValorUnitarioProducto);
                cmd.Parameters.AddWithValue("@IdCategoriaProducto", producto.CategoriaProducto);
                cmd.Parameters.AddWithValue("@FechaCreacionProducto", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioCreacionProducto", producto.UsuarioCreacionProducto);
                cmd.Parameters.AddWithValue("@EstadoProducto", producto.EstadoProducto);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int Actualizar(Producto producto)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                cmd.Parameters.AddWithValue("@DescripcionProducto", producto.DescripcionProducto);
                cmd.Parameters.AddWithValue("@AltoProducto", producto.AltoProducto);
                cmd.Parameters.AddWithValue("@AnchoProducto", producto.AnchoProducto);
                cmd.Parameters.AddWithValue("@ColorProducto", producto.ColorProducto);
                cmd.Parameters.AddWithValue("@MaterialProducto", producto.MaterialProducto);
                cmd.Parameters.AddWithValue("@GarantiaMesesProducto", producto.GarantiaMesesProducto);
                cmd.Parameters.AddWithValue("@ValorUnitarioProducto", producto.ValorUnitarioProducto);
                cmd.Parameters.AddWithValue("@IdCategoriaProducto", producto.CategoriaProducto);
                cmd.Parameters.AddWithValue("@FechaModificacionProducto", DateTime.Now);
                cmd.Parameters.AddWithValue("@UsuarioModificacionProducto", producto.UsuarioCreacionProducto);
                cmd.Parameters.AddWithValue("@EstadoProducto", producto.EstadoProducto);


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
                SqlCommand cmd = new SqlCommand("EliminarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public List<Producto> BuscarProducto(string campo, string valor)
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerProductoPorCampo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@campo", campo);
                cmd.Parameters.AddWithValue("@valor", valor);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {// IdProducto, Referencia, Nombre, Marca, Modelo, Color, Precio, Cantidad, Observacion, IdCategoria
                        Producto producto = new Producto(
                          (int)dr["IdProducto"],
                        (string)dr["NombreProducto"],
                        (string)dr["DescripcionProducto"],
                        (string)dr["AnchoProducto"],
                        (string)dr["AltoProducto"],
                        (string)dr["ColorProducto"],
                        (string)dr["MaterialProducto"],
                        (int)dr["GarantiaMesesProducto"],
                        (long)dr["ValorUnitarioProducto"],
                        (int)dr["IdCategoriaProducto"],
                        (DateTime)dr["FechaCreacionProducto"],
                        (string)dr["UsuarioCreacionProducto"],
                        (DateTime)dr["FechaModificacionProducto"],
                        (string)dr["UsuarioModificacionProducto"],
                        (int)dr["EstadoProducto"]);
                        lista.Add(producto);
                    }
                }
            }
            return lista;
        }

    }
}
