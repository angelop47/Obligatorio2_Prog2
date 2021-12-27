using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2
{
    public partial class frmLector : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listarLector();
            }
        }

        #region Métodos Auxiliares
        private bool faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtNombre.Text == "" || this.txtApellido.Text == "")
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
            this.txtId.Focus();
        }
        private void listarLector()
        {
            this.lstLectores.DataSource = null;
            Dominio.Controladora unaContra = new Dominio.Controladora();
            this.lstLectores.DataSource = unaContra.listaLectores();
            this.lstLectores.DataBind();

            
        }
        private void cargarLector(short pId)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            Dominio.Lector unLector = unaControladora.BuscarLector(pId);

            this.txtId.Text = Convert.ToString(unLector.Id);
            this.txtNombre.Text = unLector.Nombre;
            this.txtApellido.Text = unLector.Apellido;
        }

        protected void btnLimpiar_Click1(object sender, EventArgs e)
        {
            limpiar();
        }
        #endregion

        #region ABM Lectores

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                Dominio.Lector unLector = new Dominio.Lector(id, nombre, apellido);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.Alta(unLector))
                {
                    this.lblMensaje.Text = "Lector ingresado con éxito!!";
                    this.limpiar();
                    this.listarLector();
                }
                else
                {
                    this.lblMensaje.Text = "Lector ya existe!!";
                    this.limpiar();
                    this.listarLector();
                }
            }
            else
            {
                this.lblMensaje.Text = "Faltan datos!!";
                this.limpiar();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;

                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.ModificarLector(id, nombre, apellido))
                {
                    this.lblMensaje.Text = "Lector modificado con éxito!!";
                    this.limpiar();
                    this.listarLector();
                }
                else
                {
                    this.lblMensaje.Text = "Lector no está en la lista!!";
                    this.limpiar();
                }
            }
            else
            {
                this.lblMensaje.Text = "FALTAN  DATOS!!";
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.BajaLector(id))
                {
                    this.lblMensaje.Text = "Lector dado de baja con éxito!!";
                    this.limpiar();
                    this.listarLector();
                }
                else
                {
                    this.lblMensaje.Text = "No se dió de baja, no lo encontré!!";
                    this.limpiar();
                }
            }
        }
        #endregion

        #region Boton Cargar Lectores
        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (this.lstLectores.SelectedIndex > -1)
            {
                string linea = this.lstLectores.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short id = Convert.ToInt16(partes[0]);
                this.cargarLector(id);
                this.lstLectores.SelectedIndex = -1;
            }
            else
            {
                this.lblMensaje.Text = "Debe seleccionar un Lector de la lista.";
            }
        }
        #endregion

    }
}