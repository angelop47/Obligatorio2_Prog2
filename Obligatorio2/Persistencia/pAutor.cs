using Obligatorio2.Dominio;
using System.Collections.Generic;
using System.Data;

namespace Obligatorio2.Persistencia
{
    public class pAutor
    {
        private Conexion _conexion = new Conexion();

        public List<Autor> Lista()
        {
            string sql = "SELECT * FROM autor";
            DataSet resultado = this._conexion.Selección(sql);
            List<Autor> lista = new List<Autor>();
            if (resultado == null)
            {
                return lista;
            }
            DataRowCollection tabla = resultado.Tables[0].Rows;
            foreach (DataRow fila in tabla)
            {
                Autor unAutor = new Autor();
                object[] elementos = fila.ItemArray;
                unAutor.Id = short.Parse(elementos[0].ToString());
                unAutor.Nombre = elementos[1].ToString();
                unAutor.Apellido = elementos[2].ToString();
                unAutor.FechaNac = elementos[3].ToString();
                unAutor.FechaFall = elementos[4].ToString();
                unAutor.Nacionalidad = elementos[5].ToString();
                lista.Add(unAutor);
            } 
            return lista;
        } 

        public bool Alta(Autor pAutor)
        {
            string sql = "INSERT INTO autor (id_autor,nombre_autor,apellido_autor,fechaNac_autor,FechaFall_autor,nacionalidad_autor) VALUES("
                + pAutor.Id.ToString() + ",'"
                + pAutor.Nombre + "','"
                + pAutor.Apellido + "','"
                + pAutor.FechaNac + "','"
                + pAutor.FechaFall + "','"
                + pAutor.Nacionalidad + "')";
            return this._conexion.Consulta(sql);
        }

        public bool Baja(short pId)
        {
            string sql = "DELETE FROM autor WHERE id_autor=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool Modificar(Autor pAutor)
        {
            string sql = "UPDATE autor SET " + "nombre_autor='" + pAutor.Nombre + "',apellido_autor='" + pAutor.Apellido + "',fechaNac_autor='" +
                pAutor.FechaNac + "',fechaFall_autor='" + pAutor.FechaFall + "',nacionalidad_autor='" + pAutor.Nacionalidad +
                "' WHERE id_autor=" + pAutor.Id.ToString() + ";";
            return this._conexion.Consulta(sql);
        }
    }
}