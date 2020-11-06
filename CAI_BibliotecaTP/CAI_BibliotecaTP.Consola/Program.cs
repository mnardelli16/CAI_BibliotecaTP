using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAI_BibliotecaTP.Negocio;
using CAI_BibliotecaTP.Entidades;

namespace CAI_BibliotecaTP.Consola
{
    class Program
    {
        static ClienteServicio _clienteServicio;
        static void Main(string[] args)
        {
            // prueba para traer clientes de nuestro registro nada mas

            _clienteServicio = new ClienteServicio();

            List<Cliente> a = _clienteServicio.TraerClientes();

            foreach(Cliente b in a)
            {
                Console.WriteLine(b.ToString());
            }

            Console.ReadLine();
        }
    }
}
