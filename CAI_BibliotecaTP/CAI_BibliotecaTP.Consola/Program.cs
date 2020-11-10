using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAI_BibliotecaTP.Negocio;
using CAI_BibliotecaTP.Entidades;
using CAI_BibliotecaTP.Entidades.Entidades;

namespace CAI_BibliotecaTP.Consola
{
    class Program
    {
        static ClienteServicio _clienteServicio;
        static LibroServicio _libroServicio;
        static EjemplarServicio _ejemplares;
        static PrestamoServicio _prestamos;
        static void Main(string[] args)
        {
            // prueba para traer clientes de nuestro registro nada mas

            //_clienteServicio = new ClienteServicio();

            //List<Cliente> a = _clienteServicio.TraerClientes();

            //foreach(Cliente b in a)
            //{
            //    Console.WriteLine(b.ToString());
            //}


            // prueba para trear LIBROS

            //_libroServicio = new LibroServicio();

            //List<Libro> c = _libroServicio.TraerTodosLosLibros();

            //foreach (Libro d in c)
            //{
            //    Console.WriteLine(d.ToString());
            //}

            // prueba para traer EJEMPLARES

            _ejemplares = new EjemplarServicio();

            List<Ejemplar> e = _ejemplares.TraerEjemplares();

            foreach (Ejemplar a in e)
            {
                Console.WriteLine(a.ToString());
            }

            //prueba para traer PRESTAMOS

            _prestamos = new PrestamoServicio();

            List<Prestamo> p = _prestamos.TraerTodosLosPrestamos();

            foreach(Prestamo a in p)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();
        }
    }
}
