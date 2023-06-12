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
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> listaOficial = new List<Articulo>();
            try
            {            
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion,IdMarca, M.Descripcion as Marca ,IdCategoria, C.Descripcion as Categoria, ImagenUrl,Precio from ARTICULOS as A, MARCAS as M, CATEGORIAS as C where IdMarca = M.id and IdCategoria = C.Id");
                datos.ejecutaLectura();
                return listaOficial = formaLista(datos);     
            }
            catch (Exception ex)
            {

                throw ex;
            }finally
            {
                datos.cerrarConexion();          
            }  

            
        }
        public List<Articulo> filtroAvanzado(int index,int bandera,int index2 = 0)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> listaFiltrada = new List<Articulo>();
            try
            {
                if(bandera == 1)
                {
                    datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion,IdMarca, M.Descripcion as Marca ,IdCategoria, C.Descripcion as Categoria, ImagenUrl,Precio from ARTICULOS as A, MARCAS as M, CATEGORIAS as C where A.IdMarca = @index and M.Id = @index and C.Id = IdCategoria");
                    datos.setearParametros("@index", index);
                }
                else if (bandera == 2)
                {
                    datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion,IdMarca, M.Descripcion as Marca ,IdCategoria, C.Descripcion as Categoria, ImagenUrl,Precio from ARTICULOS as A, MARCAS as M, CATEGORIAS as C where C.Id = @index and A.IdCategoria = @index and M.Id = IdMarca");
                    datos.setearParametros("@index", index);
                }
                else
                {
                    datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion,IdMarca, M.Descripcion as Marca ,IdCategoria, C.Descripcion as Categoria, ImagenUrl,Precio from ARTICULOS as A, MARCAS as M, CATEGORIAS as C where C.Id = @index and A.IdCategoria = @index and M.Id = @index2 and A.IdMarca = @index2 ");
                    datos.setearParametros("@index", index);
                    datos.setearParametros("@index2", index2);      
                }
                datos.ejecutaLectura();
                Articulo aux = new Articulo();
                return listaFiltrada = formaLista(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private List<Articulo> formaLista(AccesoDatos datos)
        {
            List<Articulo> lista = new List<Articulo>();
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
                aux.Precio = Math.Truncate((Decimal)datos.Lector["Precio"]*100)/100;
                    
                lista.Add(aux);
            }
            return lista;
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

        public void modificarArg(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo , Nombre = @Nombre,Descripcion = @Descripcion, ImagenUrl = @UrlImagen,Precio = @Precio, idMarca = @idMarca, idCategoria = @idCategoria where Id = @Id");
                datos.setearParametros("@Codigo", articulo.Codigo);
                datos.setearParametros("@Nombre", articulo.Nombre);
                datos.setearParametros("@Descripcion", articulo.Descripcion);
                datos.setearParametros("@UrlImagen", articulo.UrlImagen);
                datos.setearParametros("@idMarca", articulo.Marca.id);
                datos.setearParametros("@idCategoria", articulo.Categoria.id);
                datos.setearParametros("@Precio", articulo.Precio);
                datos.setearParametros("@Id", articulo.Id);
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


    }
}
