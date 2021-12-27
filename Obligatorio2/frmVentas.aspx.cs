using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2
{
    public partial class frmVentas : System.Web.UI.Page
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
            if (this.txtId.Text == "" || this.txtPrecio.Text == "" || this.txtFecha.Text == "" || this.lstLibros.SelectedItem == null || this.lstLectores.SelectedItem == null)
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
            this.txtPrecio.Text = "";
            this.txtId.Focus();
        }
        private void listar()
        {
            Dominio.Controladora unaContra = new Dominio.Controladora();

            this.lstVentas.DataSource = null;
            this.lstVentas.DataSource = unaContra.listaVentas();
            this.lstVentas.DataBind();

            this.lstLibros.DataSource = null;
            this.lstLibros.DataSource = unaContra.listaLibros();
            this.lstLibros.DataBind();

            this.lstLectores.DataSource = null;
            this.lstLectores.DataSource = unaContra.listaLectores();
            this.lstLectores.DataBind();
        }
        private void cargar(short pId)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            Dominio.Venta unaVenta = unaControladora.BuscarVenta(pId);

            this.txtId.Text = Convert.ToString(unaVenta.Id);
            this.txtPrecio.Text = Convert.ToString(unaVenta.Precio);
            this.txtFecha.Text = unaVenta.Fecha;
        }

        protected void btnLimpiar_Click1(object sender, EventArgs e)
        {
            limpiar();
        }

        #endregion

        #region ABM Ventas

        private short enviarLibro()
        {
            string linea = lstLibros.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            return Convert.ToInt16(partes[0]);
        }
        private short enviarLector()
        {
            string linea = lstLectores.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            return Convert.ToInt16(partes[0]);
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {

            if (!this.faltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                Dominio.Libro unLibro = unaControladora.BuscarLibro(enviarLibro());
                Dominio.Lector unLector = unaControladora.BuscarLector(enviarLector());
                string fecha = this.txtFecha.Text;
                short precio = short.Parse(this.txtPrecio.Text);                   
                Dominio.Venta unaVenta = new Dominio.Venta(id, fecha, unLibro, unLector, precio);
                if (unaControladora.Alta(unaVenta))
                {
                    this.lblMensaje.Text = "Venta ingresada con éxito!!";
                    this.limpiar();
                    this.listar();
                }
                else
                {
                    this.lblMensaje.Text = "Venta ya existe!!";
                    this.limpiar();
                    this.listar();
                }
            }
        }

      

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                Dominio.Libro unLibro = unaControladora.BuscarLibro(enviarLibro());
                Dominio.Lector unLector = unaControladora.BuscarLector(enviarLector());
                string fecha = this.txtFecha.Text;
                short precio = short.Parse(this.txtPrecio.Text);
                if (unaControladora.Modificar(id, unLibro, unLector, fecha, precio))
                {
                    this.lblMensaje.Text = "Venta modificado con éxito!!";
                    this.limpiar();
                    this.listar();
                }
                else
                {
                    this.lblMensaje.Text = "Venta no está en la lista!!";
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
                if (unaControladora.BajaVenta(id))
                {
                    this.lblMensaje.Text = "Venta dado de baja con éxito!!";
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

        #region Boton Cargar Ventas
        protected void Seleccionar_Click(object sender, EventArgs e)
        {
            if (this.lstVentas.SelectedIndex > -1)
            {
                string linea = this.lstVentas.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short id = Convert.ToInt16(partes[0]);
                this.cargar(id);
                this.lstVentas.SelectedIndex = -1;
            }
            else
            {
                this.lblMensaje.Text = "Debe seleccionar un Lector de la lista.";
            }
        }
        #endregion
    }
}