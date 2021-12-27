using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2.Dominio
{
    public class Autor
    {
        //id, nombre, apellido, fecha de nacimiento, fecha de fallecimiento y nacionalidad
        private short _id;
        private string _nombre;
        private string _apellido;
        private string _fechaNac;
        private string _fechaFall;
        private string _nacionalidad;


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

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = value;
            }
        }

        public string FechaNac
        {
            get
            {
                return _fechaNac;
            }

            set
            {
                _fechaNac = value;
            }
        }

        public string FechaFall
        {
            get
            {
                return _fechaFall;
            }

            set
            {
                _fechaFall = value;
            }
        }

        public string Nacionalidad
        {
            get
            {
                return _nacionalidad;
            }

            set
            {
                _nacionalidad = value;
            }
        }

        public override string ToString()
        {
            return this.Id + " " + this.Nombre + " " + this.Apellido + " " + this.FechaNac + " " + this.FechaFall + " " + this.Nacionalidad;
        }

        public Autor(short pId, string pNombre, string pApellido, string pFechaNac, string pFechaFall, string pNacionalidad)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.FechaNac = pFechaNac;
            this.FechaFall = pFechaFall;
            this.Nacionalidad = pNacionalidad;
        }

        public Autor()
        {
        }
    }
}