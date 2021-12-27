using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2
{
    public partial class About : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                listar();
            }
        }

        #region Métodos Auxiliares
        private bool faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtNombre.Text == "" || this.txtApellido.Text == "" || this.txtAnioNac.Text == "" || this.txtAnioFall.Text == "" || this.txtNacionalidad.Text == "")
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
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtAnioNac.Text = "";
            this.txtAnioFall.Text = "";
            this.txtNacionalidad.Text = "";
            this.txtId.Focus();
        }
        private void listar()
        {
            this.lstAutores.DataSource = null;
            Dominio.Controladora unaContra = new Dominio.Controladora();
            this.lstAutores.DataSource = unaContra.listaAutores();
            this.lstAutores.DataBind();
        }
        private void cargar(short pId)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            Dominio.Autor unAutor = unaControladora.BuscarAutor(pId);

            this.txtId.Text = Convert.ToString(unAutor.Id);
            this.txtNombre.Text = unAutor.Nombre;
            this.txtApellido.Text = unAutor.Apellido;
            this.txtAnioNac.Text = unAutor.FechaNac;
            this.txtAnioFall.Text = unAutor.FechaFall;
            this.txtNacionalidad.Text = unAutor.Nacionalidad;
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        #endregion

        #region ABM Autor
        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                string fechaNac = this.txtAnioNac.Text;
                string fechaFall = this.txtAnioFall.Text;
                string nacionalidad = this.txtNacionalidad.Text;
                Dominio.Autor unAutor = new Dominio.Autor(id, nombre, apellido, fechaNac, fechaFall, nacionalidad);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.Alta(unAutor))
                {
                    this.lblMensaje.Text = "Autor ingresado con éxito!!";
                    this.limpiar();
                    this.listar();
                }
                else
                {
                    this.lblMensaje.Text = "Autor ya existe!!";
                    this.limpiar();
                    this.listar();
                }
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            short id = short.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string fechaNac = this.txtAnioNac.Text;
            string fechaFall = this.txtAnioFall.Text;
            string nacionalidad = this.txtNacionalidad.Text;
            Dominio.Autor unAutor = new Dominio.Autor(id, nombre, apellido, fechaNac, fechaFall, nacionalidad);
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            if (unaControladora.ModificarAutor(unAutor))
            {
                this.lblMensaje.Text = "Autor modificado, todo salió bien.";
                this.listar();
                this.limpiar();
            }
            else
            {
                this.lblMensaje.Text = "Modificar falló.";
            }
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            short id = short.Parse(this.txtId.Text);
            Dominio.Controladora dominio = new Dominio.Controladora();
            if (dominio.BajaAutor(id))
            {
                this.lblMensaje.Text = "Autor fue dato de baja, todo salió bien.";
                this.listar();
                this.limpiar();
            }
            else
            {
                this.lblMensaje.Text = "Baja falló.";
            }
        }
        #endregion

        #region Boton Cargar Autores
        protected void SeleccionarAutor_Click(object sender, EventArgs e)
        {
            if (this.lstAutores.SelectedIndex > -1)
            {
                string linea = this.lstAutores.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short id = Convert.ToInt16(partes[0]);
                this.cargar(id);
                this.lstAutores.SelectedIndex = -1;
            }
            else
            {
                this.lblMensaje.Text = "Debe seleccionar un alumno de la lista.";
            }
        }
        #endregion
    }
}