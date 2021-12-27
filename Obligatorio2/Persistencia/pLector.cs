using Obligatorio2.Dominio;
using System.Collections.Generic;
using System.Data;

namespace Obligatorio2.Persistencia
{
    public class pLector
    {
        private Conexion _conexion = new Conexion();

        public List<Lector> Lista()
        {
            string sql = "SELECT * FROM lectores";
            DataSet resultado = this._conexion.Selección(sql);
            List<Lector> lista = new List<Lector>();
            if (resultado == null)
            {
                return lista;
            }
            DataRowCollection tabla = resultado.Tables[0].Rows;
            foreach (DataRow fila in tabla)
            {
                Lector unLector = new Lector();
                object[] elementos = fila.ItemArray;
                unLector.Id = short.Parse(elementos[0].ToString());
                unLector.Nombre = elementos[1].ToString();
                unLector.Apellido = elementos[2].ToString();
                lista.Add(unLector);
            }
            return lista;
        }

        public bool Alta(Lector pLector)
        {
            string sql = "INSERT INTO lectores (id_Lector,nombre_Lector,apellido_Lector) VALUES("
                + pLector.Id.ToString() + ",'"
                + pLector.Nombre + "','"
                + pLector.Apellido + "')";
            return this._conexion.Consulta(sql);
        }

        public bool Baja(short pId)
        {
            string sql = "DELETE FROM lectores WHERE id_Lector=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool Modificar(Lector pLector)
        {
            string sql = "UPDATE lectores SET " + "nombre_Lector='" + pLector.Nombre + "',apellido_Lector='" + pLector.Apellido +
                "' WHERE id_Lector=" + pLector.Id.ToString() + ";";
            return this._conexion.Consulta(sql);
        }
    }
}