using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
	public class Libro
	{
		public int id { get; set; }
		public string isbn { get; set; }
		public string titulo { get; set; }
		public int edicion { get; set; }
		public int anio { get; set; }
		public string autores { get; set; }
		public string pais { get; set; }
		public string sinopsis { get; set; }
		public string carrera { get; set; }
		public string materia { get; set; }
		public Libro()
		{

		}
		public Libro(int ID, string ISBN, string TITULO, int EDICION, int ANIO, string AUTORES, string PAIS, string SINOPSIS, string CARRERA, string MATERIA)
		{
			id = ID;
			isbn = ISBN;
			titulo = TITULO;
			edicion = EDICION;
			anio = ANIO;
			autores = AUTORES;
			pais = PAIS;
			sinopsis = SINOPSIS;
			carrera = CARRERA;
			materia = MATERIA;
		}
	}
}
