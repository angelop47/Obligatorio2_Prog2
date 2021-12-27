using Obligatorio2.Dominio;
using System.Collections.Generic;
using System.Data;


namespace Obligatorio2.Persistencia
{
    public class pLibro
    {
        private Conexion _conexion = new Conexion();

        public List<Libro> Lista()
        {
            string sql = "SELECT * FROM libros";
            DataSet resultado = this._conexion.Selección(sql);
            List<Libro> lista = new List<Libro>();
            if (resultado == null)
            {
                return lista;
            }
            DataRowCollection tabla = resultado.Tables[0].Rows;
            foreach (DataRow fila in tabla)
            {
                Libro unLibro = new Libro();
                Genero unGenero = new Genero();
                Autor unAutor = new Autor();
                object[] elementos = fila.ItemArray;
                unLibro.Id = short.Parse(elementos[0].ToString());
                unLibro.Titulo = elementos[1].ToString();
                unGenero.Nombre = elementos[2].ToString();
                unLibro.Año = elementos[3].ToString();
                unAutor.Nombre = elementos[4].ToString();
                unLibro.Precio = short.Parse(elementos[5].ToString());
                unLibro.Comentario = elementos[6].ToString();
                lista.Add(unLibro);
            }
            return lista;
        }

        public bool Alta(Libro pLibro)
        {
            string sql = "INSERT INTO libros (id_libro,titulo_libro,genero_libro,año_libro,autor_libro,precio_libro,comentario_libro) VALUES("
                + pLibro.Id.ToString() + ",'"
                + pLibro.Titulo + "','"
                + pLibro.Genero.Nombre + "','"
                + pLibro.Año + "','"
                + pLibro.Autor.Nombre + "','"
                + pLibro.Precio + "','"
                + pLibro.Comentario + "')";
            return this._conexion.Consulta(sql);
        }

        public bool Baja(short pId)
        {
            string sql = "DELETE FROM libros WHERE id_Libro=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool Modificar(Libro pLibro)
        {
            string sql = "UPDATE libros SET " + "titulo_libro='" + pLibro.Titulo + "',titulo_libro='" + pLibro.Genero.Nombre +
                "',genero_libro='" + pLibro.Genero.Nombre + "',año_libro='" + pLibro.Año + "',autor_libro='" + pLibro.Autor.Nombre +
                "',precio_libro='" + pLibro.Precio + "',comentario_libro='" + pLibro.Comentario +
                "' WHERE id_libro=" + pLibro.Id.ToString() + ";";
            return this._conexion.Consulta(sql);
        }
    }
}