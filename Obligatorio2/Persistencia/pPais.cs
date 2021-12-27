using Obligatorio2.Dominio;
using System.Collections.Generic;
using System.Data;

namespace Obligatorio2.Persistencia
{
    public class pPais
    {
        private Conexion _conexion = new Conexion();

        public List<Pais> Lista()
        {
            string sql = "SELECT * FROM paises";
            DataSet resultado = this._conexion.Selección(sql);
            List<Pais> lista = new List<Pais>();
            if (resultado == null)
            {
                return lista;
            }
            DataRowCollection tabla = resultado.Tables[0].Rows;
            foreach (DataRow fila in tabla)
            {
                Pais unPais = new Pais();
                object[] elementos = fila.ItemArray;
                unPais.Id = short.Parse(elementos[0].ToString());
                unPais.Nombre = elementos[1].ToString();
                lista.Add(unPais);
            }
            return lista;
        }

        public bool Alta(Pais pPais)
        {
            string sql = "INSERT INTO paises (id_pais,nombre_pais) VALUES("
                + pPais.Id.ToString() + ",'"
                + pPais.Nombre + "')";
            return this._conexion.Consulta(sql);
        }

        public bool Baja(short pId)
        {
            string sql = "DELETE FROM paises WHERE id_pais=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool Modificar(Pais pPais)
        {
            string sql = "UPDATE paises SET " + "nombre_pais='" + pPais.Nombre +
                "' WHERE id_pais=" + pPais.Id.ToString() + ";";
            return this._conexion.Consulta(sql);
        }
    }
}