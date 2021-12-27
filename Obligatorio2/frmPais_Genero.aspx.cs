using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2
{
    public partial class Pais_Genero : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listarPaises();
                listarGenero();
            }
        }
        #region Métodos Auxiliares paises
        private bool faltanDatos()
        {
            if (this.txtIdPais.Text == "" || this.txtNombrePais.Text == "")
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
            this.txtIdPais.Text = "";
            this.txtNombrePais.Text = "";
            this.txtIdPais.Focus();
        }
        private void listarPaises()
        {
            this.lstPaises.DataSource = null;
            Dominio.Controladora unaContra = new Dominio.Controladora();
            this.lstPaises.DataSource = unaContra.listaPaises();
            this.lstPaises.DataBind();
        }
        private void cargarPais(short pId)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            Dominio.Pais unPais = unaControladora.BuscarPais(pId);

            this.txtIdPais.Text = Convert.ToString(unPais.Id);
            this.txtNombrePais.Text = unPais.Nombre;
        }
        #endregion

        #region ABM Paises

        protected void btnAltaPais_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = Convert.ToInt16(this.txtIdPais.Text);
                string nombre = this.txtNombrePais.Text;
                Dominio.Pais unPais = new Dominio.Pais(id, nombre);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.AltaPais(unPais))
                {
                    this.lblMensaje.Text = "Pais ingresado con éxito!!";
                    this.limpiar();
                    this.listarPaises();
                }
                else
                {
                    this.lblMensaje.Text = "Pais ya existe!!";
                    this.limpiar();
                    this.listarPaises();
                }
            }
            else
            {
                this.lblMensaje.Text = "Faltan datos!!";
                this.limpiar();
            }
        }

        protected void btnModificarPais_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtIdPais.Text);
                string nombre = this.txtNombrePais.Text;

                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.ModificarPais(id, nombre))
                {
                    this.lblMensaje.Text = "Pais modificado con éxito!!";
                    this.limpiar();
                    this.listarPaises();
                }
                else
                {
                    this.lblMensaje.Text = "Pais no está en la lista!!";
                    this.limpiar();
                }
            }
            else
            {
                this.lblMensaje.Text = "FALTAN  DATOS!!";
            }
        }

        protected void btnBajaPais_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtIdPais.Text);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.BajaPais(id))
                {
                    this.lblMensaje.Text = "Pais dado de baja con éxito!!";
                    this.limpiar();
                    this.listarPaises();
                }
                else
                {
                    this.lblMensaje.Text = "No se dió de baja, no lo encontré!!";
                    this.limpiar();
                }
            }
        }

        protected void btnLimpiarPais_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region Métodos Auxiliares Genero
        private bool faltanDatosGenero()
        {
            if (this.txtIdGenero.Text == "" || this.txtNombreGenero.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void limpiarGenero()
        {
            this.txtIdGenero.Text = "";
            this.txtNombreGenero.Text = "";
            this.txtIdGenero.Focus();
        }
        private void listarGenero()
        {
            this.lstGenero.DataSource = null;
            Dominio.Controladora unaContra = new Dominio.Controladora();
            this.lstGenero.DataSource = unaContra.listaGenero();
            this.lstGenero.DataBind();
        }
        private void cargarGenero(short pId)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            Dominio.Genero unGenero = unaControladora.BuscarGenero(pId);

            this.txtIdGenero.Text = Convert.ToString(unGenero.Id);
            this.txtNombreGenero.Text = unGenero.Nombre;
        }
        #endregion

        #region ABM Genero
        protected void btnAltaGenero_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatosGenero())
            {
                short id = Convert.ToInt16(this.txtIdGenero.Text);
                string nombre = this.txtNombreGenero.Text;
                Dominio.Genero unGenero = new Dominio.Genero(id, nombre);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.AltaGenero(unGenero))
                {
                    this.lblMensajeGenero.Text = "Genero ingresado con éxito!!";
                    this.limpiar();
                    this.listarGenero();
                }
                else
                {
                    this.lblMensajeGenero.Text = "Genero ya existe!!";
                    this.limpiar();
                    this.listarGenero();
                }
            }
            else
            {
                this.lblMensajeGenero.Text = "Faltan datos!!";
                this.limpiar();
            }
        }

        protected void btnModificarGenero_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtIdGenero.Text);
                string nombre = this.txtNombreGenero.Text;

                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.ModificarGenero(id, nombre))
                {
                    this.lblMensajeGenero.Text = "Genero modificado con éxito!!";
                    this.limpiar();
                    this.listarGenero();
                }
                else
                {
                    this.lblMensajeGenero.Text = "Genero no está en la lista!!";
                    this.limpiar();
                }
            }
        }

        protected void btnBajaGenero_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtIdGenero.Text);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                if (unaControladora.BajaPais(id))
                {
                    this.lblMensajeGenero.Text = "Pais dado de baja con éxito!!";
                    this.limpiar();
                    this.listarGenero();
                }
                else
                {
                    this.lblMensajeGenero.Text = "No se dió de baja, no lo encontré!!";
                    this.limpiar();
                }
            }
        }

        protected void btnLimpiarGenero_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}