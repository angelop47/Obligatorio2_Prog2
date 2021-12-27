using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2.Dominio
{
    public class Venta
    {
        private short _id;
        private string _fecha;
        private Libro _libro;
        private Lector _lector;
        private short _precio;


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

        public string Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        public Libro Libro
        {
            get
            {
                return _libro;
            }

            set
            {
                _libro = value;
            }
        }

        public Lector Lector
        {
            get
            {
                return _lector;
            }

            set
            {
                _lector = value;
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

        public override string ToString()
        {
            return this.Id + " " + this.Fecha + " Autor: " + this.Libro + " Lector: " + this.Lector + " $" + this.Precio;
        }

        public Venta(short pId, string pFecha, Libro pLibro, Lector pLector, short pPrecio)
        {
            this.Id = pId;
            this.Fecha = pFecha;
            this.Libro = pLibro;
            this.Lector = pLector;
            this.Precio = pPrecio;
        }

        public Venta()
        {

        }
    }
}