using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion,IdMarca, M.Descripcion as Marca ,IdCategoria, C.Descripcion as Categoria, ImagenUrl,Precio from ARTICULOS as A, MARCAS as M, CATEGORIAS as C where IdMarca = M.id and IdCategoria = C.Id");
                datos.ejecutaLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];

                    aux.Codigo = (string)datos.Lector["Codigo"];

                    aux.Nombre = (string)datos.Lector["Nombre"];

                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    string v = aux.Precio.ToString("0.0");
                    aux.Precio = Decimal.Parse(v);
                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void eliminarArt(int seleccionado)
        {
            AccesoDatos datos= new AccesoDatos();

            try
            {
                
                datos.setearConsulta("delete from ARTICULOS where Id = @seleccionado");
                datos.setearParametros("seleccionado", seleccionado);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarArg(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre,Descripcion, ImagenUrl,Precio, idMarca, idCategoria) values  (@Codigo, @Nombre, @Descripcion, @UrlImagen, @Precio, @idMarca, @idCategoria)");
                datos.setearParametros("@Codigo", nuevo.Codigo);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@UrlImagen", nuevo.UrlImagen);
                datos.setearParametros("@idMarca",nuevo.Marca.id);
                datos.setearParametros("@idCategoria", nuevo.Categoria.id);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
