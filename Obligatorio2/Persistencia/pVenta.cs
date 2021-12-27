using Obligatorio2.Dominio;
using System.Collections.Generic;
using System.Data;

namespace Obligatorio2.Persistencia
{
    public class pVenta
    {
        private Conexion _conexion = new Conexion();

        public List<Venta> Lista()
        {
            string sql = "SELECT * FROM ventas";
            DataSet resultado = this._conexion.Selección(sql);
            List<Venta> lista = new List<Venta>();
            if (resultado == null)
            {
                return lista;
            }
            DataRowCollection tabla = resultado.Tables[0].Rows;
            foreach (DataRow fila in tabla)
            {
                Venta unaVenta = new Venta();
                Libro unLibro = new Dominio.Libro();
                Lector unLector = new Lector();
                object[] elementos = fila.ItemArray;
                unaVenta.Id = short.Parse(elementos[0].ToString());
                unaVenta.Fecha = elementos[1].ToString();
                unLibro.Titulo = elementos[2].ToString();
                unLector.Nombre = elementos[3].ToString();
                unaVenta.Precio = short.Parse(elementos[4].ToString());
             
                lista.Add(unaVenta);
            }
            return lista;
        }

        public bool Alta(Venta pVenta)
        {
            string sql = "INSERT INTO ventas (id_venta,fecha_venta,libro_venta,lector_venta,precio_venta) VALUES("
                + pVenta.Id.ToString() + ",'"
                + pVenta.Fecha + "','"
                + pVenta.Libro.Titulo + "','"
                + pVenta.Lector.Nombre + "','"
                + pVenta.Precio + "')";
            return this._conexion.Consulta(sql);
        }

        public bool Baja(short pId)
        {
            string sql = "DELETE FROM ventas WHERE id_venta=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool Modificar(Venta pVenta)
        {
            string sql = "UPDATE ventas SET " + "fecha_venta='" + pVenta.Fecha + "',libro_venta='" + pVenta.Libro.Titulo +
                "',lector_venta='" + pVenta.Lector.Nombre + "',precio_venta='" + pVenta.Precio +
                "' WHERE id_Venta=" + pVenta.Id.ToString() + ";";
            return this._conexion.Consulta(sql);
        }
    }
}