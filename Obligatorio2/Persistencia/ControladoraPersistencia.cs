using Obligatorio2.Dominio;
using System.Collections.Generic;

namespace Obligatorio2.Persistencia
{
    public class ControladoraPersistencia
    {
        #region Persistencia Autor

        public bool AltaAutor(Autor pAutor)
        {
            return new pAutor().Alta(pAutor);
        }

        public bool BajaAutor(short pId)
        {
            return new pAutor().Baja(pId);
        }

        public bool ModificarAlumno(Autor pAutor)
        {
            return new pAutor().Modificar(pAutor);
        }

        public List<Autor> ListaAutores()
        {
            return new pAutor().Lista();
        }

        #endregion

        #region persistencia Lector      
        public bool AltaLector(Lector pLector)
        {
            return new pLector().Alta(pLector);
        }

        public bool BajaLector(short pId)
        {
            return new pLector().Baja(pId);
        }

        public bool MOdificarLector(Lector pLector)
        {
            return new pLector().Modificar(pLector);
        }

        public List<Lector> ListaLectores()
        {
            return new pLector().Lista();
        }

        #endregion

        #region Persistencia Genero
        public bool AltaGenero(Genero pGenero)
        {
            return new pGenero().Alta(pGenero);
        }

        public bool BajaGenero(short pId)
        {
            return new pGenero().Baja(pId);
        }

        public bool ModificarGenero(Genero pGenero)
        {
            return new pGenero().Modificar(pGenero);
        }

        public List<Genero> ListaGenero()
        {
            return new pGenero().Lista();
        }

        #endregion

        #region Persistencia Pais
        public bool AltaPais(Pais pPais)
        {
            return new pPais().Alta(pPais);
        }

        public bool BajaPais(short pId)
        {
            return new pPais().Baja(pId);
        }

        public bool ModificarPais(Pais pPais)
        {
            return new pPais().Modificar(pPais);
        }

        public List<Pais> ListaPaises()
        {
            return new pPais().Lista();
        }

        #endregion

        #region Persistencia Libro
        public bool AltaLibro(Libro pLibro)
        {
            return new pLibro().Alta(pLibro);
        }

        public bool BajaLibro(short pId)
        {
            return new pLibro().Baja(pId);
        }

        public bool ModificarLibro(Libro pLibro)
        {
            return new pLibro().Modificar(pLibro);
        }

        public List<Libro> ListaLibros()
        {
            return new pLibro().Lista();
        }

        #endregion

        #region Persistencia Venta
        public bool AltaVenta(Venta pVenta)
        {
            return new pVenta().Alta(pVenta);
        }

        public bool BajaVenta(short pId)
        {
            return new pVenta().Baja(pId);
        }

        public bool ModificarVenta(Venta pVenta)
        {
            return new pVenta().Modificar(pVenta);
        }

        public List<Venta> ListaVentas()
        {
            return new pVenta().Lista();
        }

        #endregion

    }
}