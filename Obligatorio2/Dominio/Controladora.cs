using Obligatorio2.Persistencia;
using System.Collections.Generic;

namespace Obligatorio2.Dominio
{
    public class Controladora
    {
        public Controladora()
        {
            this._persistencia = new ControladoraPersistencia();
            this._listaAutores = _persistencia.ListaAutores();
            this._listaLectores = _persistencia.ListaLectores();
            this._listaPaises = _persistencia.ListaPaises();
            this._listaGenero = _persistencia.ListaGenero();
            this._listaLibros = _persistencia.ListaLibros();
            this._listaVentas = _persistencia.ListaVentas();
        }

        private ControladoraPersistencia _persistencia;
        private List<Libro> _listaLibros = new List<Libro>();
        private List<Autor> _listaAutores = new List<Autor>();
        private List<Lector> _listaLectores = new List<Lector>();
        private List<Pais> _listaPaises = new List<Pais>();
        private List<Genero> _listaGenero = new List<Genero>();
        private List<Venta> _listaVentas = new List<Venta>();

        #region ABM Libros
        public List<Libro> listaLibros()
        {
            return _listaLibros;
        }

        public Libro BuscarLibro(short pId)
        {
            foreach (Libro unLibro in _listaLibros)
            {
                if (unLibro.Id == pId)
                    return unLibro;
            }
            return null;
        }

        public bool Alta(Libro pLibro)
        {
            Libro unLibro = BuscarLibro(pLibro.Id);
            if (unLibro == null)
            {
                //_listaLibros.Add(pLibro);
                _persistencia.AltaLibro(pLibro);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaLibro(short pId)
        {
            Libro unLibro = this.BuscarLibro(pId);
            if (unLibro != null)
            {
                //_listaLibros.Remove(unLibro);
                _persistencia.BajaLibro(pId);
                return true;
            }
            else
                return false;
        }

        public bool ModificarLibro(short pId, string pTitulo, Genero pGenero, string pAño, Autor pAutor, short pPrecio, string pComentario)
        {
            Libro unLibro = BuscarLibro(pId);
            if (unLibro != null)
            {
                unLibro.Titulo = pTitulo;
                unLibro.Genero = pGenero;
                unLibro.Año = pAño;
                unLibro.Genero = pGenero;
                unLibro.Precio = pPrecio;
                unLibro.Comentario = pComentario;
                return true;
            }
            else
                return false;
        }
        #endregion
        
        #region ABM Autores
        public List<Autor> listaAutores()
        {
            return _listaAutores;
        }

        public Autor BuscarAutor(short pId)
        {
            foreach (Autor unAutor in _listaAutores)
            {
                if (unAutor.Id == pId)
                    return unAutor;
            }
            return null;
        }

        public bool Alta(Autor pAutor)
        {
            Autor unAutor = BuscarAutor(pAutor.Id);
            if (unAutor == null)
            {
                // _listaAutores.Add(pAutor);
                _persistencia.AltaAutor(pAutor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaAutor(short pId)
        {
            Autor unAutor = this.BuscarAutor(pId);
            if (unAutor != null)
            {
                //_listaAutores.Remove(unAutor);
                _persistencia.BajaAutor(pId);
                return true;
            }
            else
                return false;
        }

        public bool ModificarAutor(Autor pAutor)
        {
            Autor unAutor = this.BuscarAutor(pAutor.Id);
            if (unAutor != null)
            {
                if (this._persistencia.ModificarAlumno(pAutor))
                {
                    unAutor.Nombre = pAutor.Nombre;
                    unAutor.Apellido = pAutor.Apellido;
                    unAutor.Nacionalidad = pAutor.Nacionalidad;
                    unAutor.FechaNac = pAutor.FechaNac;
                    unAutor.FechaFall = pAutor.FechaFall;
                    return true;
                }
            }
            return false;
        }

        /*public bool ModificarAutor(short pId, string pNombre, string pApellido, string pFechaNac, string pFechaFall, string pNacionalidad)
        {
            Autor unAutor = BuscarAutor(pId);
            if (unAutor != null)
            {
                unAutor.Nombre = pNombre;
                unAutor.Apellido = pApellido;
                unAutor.FechaNac = pFechaNac;
                unAutor.FechaFall = pFechaFall;
                unAutor.Nacionalidad = pNacionalidad;
                return true;
            }
            else
                return false;
        }*/
        #endregion

        #region ABM Lectores
        public List<Lector> listaLectores()
        {
            return _listaLectores;
        }

        public Lector BuscarLector(short pId)
        {
            foreach (Lector unLector in _listaLectores)
            {
                if (unLector.Id == pId)
                    return unLector;
            }
            return null;
        }

        public bool Alta(Lector pLector)
        {
            Lector unLector = BuscarLector(pLector.Id);
            if (unLector == null)
            {
                //_listaLectores.Add(pLector);
                _persistencia.AltaLector(pLector);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaLector(short pId)
        {
            Lector unLector = this.BuscarLector(pId);
            if (unLector != null)
            {
                //_listaLectores.Remove(unLector);
                _persistencia.BajaLector(pId);
                return true;
            }
            else
                return false;
        }

        public bool ModificarLector(short pId, string pNombre, string pApellido)
        {
            Lector unAutor = BuscarLector(pId);
            if (unAutor != null)
            {
                unAutor.Nombre = pNombre;
                unAutor.Apellido = pApellido;

                return true;
            }
            else
                return false;
        }
        #endregion

        #region ABM Paises
        public List<Pais> listaPaises()
        {
            return _listaPaises;
        }

        public Pais BuscarPais(short pId)
        {
            foreach (Pais unPais in _listaPaises)
            {
                if (unPais.Id == pId)
                    return unPais;
            }
            return null;
        }

        public bool AltaPais(Pais pPais)
        {
            Pais unPais = BuscarPais(pPais.Id);
            if (unPais == null)
            {
                _persistencia.AltaPais(pPais);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaPais(short pId)
        {
            Pais unPais = this.BuscarPais(pId);
            if (unPais != null)
            {
                _persistencia.BajaPais(pId);
                return true;
            }
            else
                return false;
        }

        public bool ModificarPais(short pId, string pNombre)
        {
            Pais unPais = BuscarPais(pId);
            if (unPais != null)
            {
                unPais.Nombre = pNombre;
                return true;
            }
            else
                return false;
        }
        #endregion

        #region ABM Genero
        public List<Genero> listaGenero()
        {
            return _listaGenero;
        }

        public Genero BuscarGenero(short pId)
        {
            foreach (Genero unGenero in _listaGenero)
            {
                if (unGenero.Id == pId)
                    return unGenero;
            }
            return null;
        }

        public bool AltaGenero(Genero pGenero)
        {
            Genero unGenero = BuscarGenero(pGenero.Id);
            if (unGenero == null)
            {
                //_listaLectores.Add(pLector);
                _persistencia.AltaGenero(pGenero);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaGenero(short pId)
        {
            Genero unGenero = this.BuscarGenero(pId);
            if (unGenero != null)
            {
                //_listaLectores.Remove(unLector);
                _persistencia.BajaGenero(pId);
                return true;
            }
            else
                return false;
        }

        public bool ModificarGenero(short pId, string pNombre)
        {
            Genero unGenero = BuscarGenero(pId);
            if (unGenero != null)
            {
                unGenero.Nombre = pNombre;
                return true;
            }
            else
                return false;
        }
        #endregion

        #region ABM Ventas
        public List<Venta> listaVentas()
        {
            return _listaVentas;
        }

        public Venta BuscarVenta(short pId)
        {
            foreach (Venta unaVenta in _listaVentas)
            {
                if (unaVenta.Id == pId)
                    return unaVenta;
            }
            return null;
        }

        public bool Alta(Venta pVenta)
        {
            Venta unaVenta = BuscarVenta(pVenta.Id);
            if (unaVenta == null)
            {
                _listaVentas.Add(pVenta);
                _persistencia.AltaVenta(pVenta);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaVenta(short pId)
        {
            Venta unaVenta = this.BuscarVenta(pId);
            if (unaVenta != null)
            {
                //_listaVentas.Remove(unaVenta);
                _persistencia.BajaVenta(pId);
                return true;
            }
            else
                return false;
        }

        public bool Modificar(short pId, Libro pLibro, Lector pLector, string pFecha, short pPrecio)
        {
            Venta unaVenta = BuscarVenta(pId);
            if (unaVenta != null)
            {
                unaVenta.Fecha = pFecha;

                return true;
            }
            else
                return false;
        }
        #endregion

        #region Consultas

        //Mostrar la lista de libros ordenados por título alfabéticamente.
        public List<Libro> LibrosOrdenados()
        {
            List<Libro> LibrosOrdenados = new List<Libro>(_listaLibros);
            for (int i = 0; i < LibrosOrdenados.Count; i++)
            {
                for (int j = 0; j < LibrosOrdenados.Count - 1; j++)
                {
                    if (LibrosOrdenados[j].Titulo.CompareTo(LibrosOrdenados[j + 1].Titulo) > 0)
                    {
                        Libro unLibro = LibrosOrdenados[j];
                        LibrosOrdenados[j] = LibrosOrdenados[j + 1];
                        LibrosOrdenados[j + 1] = unLibro;
                    }
                }
            }

            return LibrosOrdenados;
        }

        //Dado un lector mostrar los títulos de los libros que compró.

        public List<Venta> MostrarLectores(Lector pLector)
        {
            List<Venta> listaLectores = new List<Venta>();
            foreach (Venta unaVenta in _listaVentas)
            {
                if (unaVenta.Lector == pLector)
                {
                    listaLectores.Add(unaVenta);
                }
            }
            
            return listaLectores;
        }

     
        #endregion


    }
}