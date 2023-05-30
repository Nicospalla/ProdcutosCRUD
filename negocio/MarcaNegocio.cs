using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
	public class MarcaNegocio
	{
		AccesoDatos datos = new AccesoDatos();
	
		public List<Marca> listar()
		{
			List<Marca> lista = new List<Marca>();
			try
			{
				datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
				datos.ejecutaLectura();

				while(datos.Lector.Read())
				{
					Marca aux = new Marca();

					aux.id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					lista.Add(aux);
				}
				return lista;
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
	}
}

