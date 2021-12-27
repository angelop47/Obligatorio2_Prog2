using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2
{
    public partial class frmLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                listar();
            }
            cargarLibrosOrdenados();
        }

        #region Métodos Auxiliares
        private bool faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtTitulo.Text == "" || this.lstGeneroLibro.SelectedItem == null || this.txtAnio.Text == "" || this.lstAutoresLibro.SelectedItem == null || this.txtPrecio.Text == "" || this.txtComentario.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void limpiar()
        {
            this.txtId.Text = "";
            this.txtTitulo.Text = "";
            this.txtAnio.Text = "";
            this.txtPrecio.Text = "";
            this.txtComentario.Text = "";
            this.txtId.Focus();
        }
        private void listar()
        {
            this.lstLibro.DataSource = null;
            Dominio.Controladora unaContra = new Dominio.Controladora();
            this.lstLibro.DataSource = unaContra.listaLibros();
            this.lstLibro.DataBind();

            this.lstAutoresLibro.DataSource = null;
            this.lstAutoresLibro.DataSource = unaContra.listaAutores();
            this.lstAutoresLibro.DataBind();

            this.lstGeneroLibro.DataSource = null;
            this.lstGeneroLibro.DataSource = unaContra.listaGenero();
            this.lstGeneroLibro.DataBind();
        }


        private void cargar(short pId)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            Dominio.Libro unLibro = unaControladora.BuscarLibro(pId);

            this.txtId.Text = Convert.ToString(unLibro.Id);
            this.txtTitulo.Text = unLibro.Titulo;
            this.txtAnio.Text = Convert.ToString(unLibro.Año);
            this.txtPrecio.Text = Convert.ToString(unLibro.Precio);
            this.txtComentario.Text = unLibro.Comentario;
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        
        #endregion

        #region ABM Libros
            private short enviarGenero()
            {
                string linea = lstGeneroLibro.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                return Convert.ToInt16(partes[0]);
            }
            private short enviarAutor()
            {
            string linea = lstAutoresLibro.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            return Convert.ToInt16(partes[0]);
            }

        protected void btnsave_Click(object sender, EventArgs e)
        {
             if (!this.faltanDatos())
             {
                Dominio.Controladora unaControladora = new Dominio.Controladora();

                 short id = Convert.ToInt16(this.txtId.Text);
                 string titulo = this.txtTitulo.Text;
                 Dominio.Genero unGenero = unaControladora.BuscarGenero(enviarGenero());
                 string año = this.txtAnio.Text;
                 Dominio.Autor unAutor = unaControladora.BuscarAutor(enviarAutor());
                 short precio = short.Parse(this.txtPrecio.Text);
                 string comentario = this.txtComentario.Text;
                 Dominio.Libro unLibro = new Dominio.Libro(id, titulo, unGenero, año, unAutor, precio, comentario);
                 if (unaControladora.Alta(unLibro))
                 {
                     this.lblMensaje.Text = "Libro ingresado con éxito!!";
                     this.limpiar();
                     this.listar();
                 }
                 else
                 {
                     this.lblMensaje.Text = "Libro ya existe!!";
                     this.limpiar();
                     this.listar();
                 }
             }
             else
             {
                 this.lblMensaje.Text = "Faltan datos!!";
             }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                short id = short.Parse(this.txtId.Text);
                string titulo = this.txtTitulo.Text;
                Dominio.Genero unGenero = unaControladora.BuscarGenero(enviarGenero());
                Dominio.Autor unAutor = unaControladora.BuscarAutor(enviarAutor());
                string año = this.txtAnio.Text;
                short precio = short.Parse(this.txtPrecio.Text);
                string comentario = this.txtComentario.Text;
                if (unaControladora.ModificarLibro(id, titulo, unGenero, año, unAutor, precio, comentario))
                {
                    this.lblMensaje.Text = "Libro modificado con éxito!!";
                    this.limpiar();
                    this.listar();
                }
                else
                {
                    this.lblMensaje.Text = "Libro no está en la lista!!";
                    this.limpiar();
                }
            }
            else
            {
                this.lblMensaje.Text = "FALTAN  DATOS!!";
            }
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.BajaLibro(id))
                {
                    this.lblMensaje.Text = "Libro dado de baja con éxito!!";
                    this.limpiar();
                    this.listar();
                }
                else
                {
                    this.lblMensaje.Text = "No se dió de baja, no lo encontré!!";
                    this.limpiar();
                }
            }
        }
        #endregion

        #region Boton Cargar Libros
        protected void Seleccionar_Click(object sender, EventArgs e)
        {

            if (this.lstLibro.SelectedIndex > -1)
            {
                string linea = this.lstLibro.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short id = Convert.ToInt16(partes[0]);
                this.cargar(id);
                this.lstLibro.SelectedIndex = -1;
            }
            else
            {
                this.lblMensaje.Text = "Debe seleccionar un Lector de la lista.";
            }
        }
        #endregion

        #region Consulta Libros Ordenados
        private void cargarLibrosOrdenados()
        {
            this.lstLibrosOrdenados.DataSource = null;
            Dominio.Controladora unaContra = new Dominio.Controladora();
            this.lstLibrosOrdenados.DataSource = unaContra.LibrosOrdenados();
            this.lstLibrosOrdenados.DataBind();
        }
        protected void Refresh_Click(object sender, EventArgs e)
        {
            cargarLibrosOrdenados();
        }
        #endregion

        
    }
}