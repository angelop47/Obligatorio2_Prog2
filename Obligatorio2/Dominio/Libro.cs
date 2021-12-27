using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2.Dominio
{
    public class Libro
    {
        private short _id;
        private string _titulo;
        private Genero _genero;
        private string _año;
        private Autor _autor;
        private short _precio;
        private string _comentario;


        public short Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        public Genero Genero
        {
            get
            {
                return _genero;
            }

            set
            {
                _genero = value;
            }
        }

        public string Año
        {
            get
            {
                return _año;
            }

            set
            {
                _año = value;
            }
        }
        
        public Autor Autor
        {
            get
            {
                return _autor;
            }

            set
            {
                _autor = value;
            }
        }
        
        public short Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                _precio = value;
            }
        }

        public string Comentario
        {
            get
            {
                return _comentario;
            }

            set
            {
                _comentario = value;
            }
        }

        public override string ToString()
        {
            return this.Id + " " + this.Titulo + " " + this.Genero + " " + this.Año + " " + this.Autor + " " + this.Precio + " " + this.Comentario;
        }

        public Libro(short pId, string pTitulo, Genero pGenero, string pAño, Autor pAutor, short pPrecio, string pComentario)
        {
            this.Id = pId;
            this.Titulo = pTitulo;
            this.Genero = pGenero;
            this.Año = pAño;
            this.Autor = pAutor;
            this.Precio = pPrecio;
            this.Comentario = pComentario;
        }

        public Libro()
        {

        }
    }
}