using CAI_BibliotecaTP.Datos;
using CAI_BibliotecaTP.Entidades;
using CAI_BibliotecaTP.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Negocio
{
    public class LibroServicio
    {
        private LibroMapper _mapper;

        public LibroServicio()
        {
            _mapper = new LibroMapper();
        }

        public List<Libro> TraerTodosLosLibros()
        {
            List<Libro> resultado = _mapper.TraerTodosLosLibros();
            return resultado;
        }

        public int InsertarLibro(Libro L)
        {
            List<Libro> result = _mapper.TraerTodosLosLibros();

            foreach (Libro Libro in result) // valida el negocio que no este ya cargado
            {
                if (Libro.Titulo == L.Titulo)
                {
                    throw new Exception("El Libro ya se encuentra cargado");
                }
            }

            TransactionResult resultado = _mapper.Insert(L);

            if (!resultado.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor.Detalle: " + resultado.Error);
            }
            else
            {
                return resultado.Id;
            }
        }

    }
}
