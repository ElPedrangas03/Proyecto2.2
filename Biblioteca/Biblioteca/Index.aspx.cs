using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelos;
using Datos;
using System.Runtime.InteropServices.ComTypes;

namespace Biblioteca
{
    public partial class Index : System.Web.UI.Page
    {
		/*
						ISBN VARCHAR(20),
						TITULO VARCHAR(100),
						NUM_EDICION INT,
						AÑO_PUBLICACION INT,
						AUTORES VARCHAR(100),
						PAIS_PUBLICACION VARCHAR(50),
						SINOPSIS TEXT,
						CARRERA VARCHAR(50),
						MATERIA VARCHAR(50)*/
		public void btnEnviar_Click(object sender, EventArgs e)
        {
            Libro librito = new Libro();
            librito.titulo = txtLibro.Text;
			librito.isbn = txtISBN.Text;
			librito.edicion = Convert.ToInt32(txtEdicion.Text);
			librito.anio = Convert.ToInt32(txtPublicacion.Text);
			librito.autores = txtAutores.Text;
            librito.pais= txtPais.Text;
            librito.sinopsis = txtSinopsis.Text;
			librito.carrera = ddlCarreras.Text;
			librito.materia = txtMateria.Text;
			new LibrosDAO().InsertLibro(librito);
            GridViewLibros.DataSource = Get();
            GridViewLibros.DataBind();
			txtLibro.Text = "";
			txtISBN.Text = "";
			txtEdicion.Text = "";
			txtPublicacion.Text = "";
			txtAutores.Text = "";
			txtPais.Text = "";
			txtSinopsis.Text = "";
			txtMateria.Text = "";

        }

        private List<Libro> Get()
        {
            return new LibrosDAO().getAll();
        }

        public void GridViewLibros_Load(object sender, EventArgs e)
		{
			GridViewLibros.DataSource = Get();
			GridViewLibros.DataBind();
		}
		
	}

}