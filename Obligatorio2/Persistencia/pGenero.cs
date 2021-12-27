using Obligatorio2.Dominio;
using System.Collections.Generic;
using System.Data;

namespace Obligatorio2.Persistencia
{
    public class pGenero
    {
        private Conexion _conexion = new Conexion();

        public List<Genero> Lista()
        {
            string sql = "SELECT * FROM Genero";
            DataSet resultado = this._conexion.Selección(sql);
            List<Genero> lista = new List<Genero>();
            if (resultado == null)
            {
                return lista;
            }
            DataRowCollection tabla = resultado.Tables[0].Rows;
            foreach (DataRow fila in tabla)
            {
                Genero unGenero = new Genero();
                object[] elementos = fila.ItemArray;
                unGenero.Id = short.Parse(elementos[0].ToString());
                unGenero.Nombre = elementos[1].ToString();
                lista.Add(unGenero);
            }
            return lista;
        }

        public bool Alta(Genero pGenero)
        {
            string sql = "INSERT INTO genero (id_genero,nombre_genero) VALUES("
                + pGenero.Id.ToString() + ",'"
                + pGenero.Nombre + "')";
            return this._conexion.Consulta(sql);
        }

        public bool Baja(short pId)
        {
            string sql = "DELETE FROM genero WHERE id_genero=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool Modificar(Genero pGenero)
        {
            string sql = "UPDATE genero SET " + "nombre_genero='" + pGenero.Nombre +
                "' WHERE id_genero=" + pGenero.Id.ToString() + ";";
            return this._conexion.Consulta(sql);
        }
    }
}