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
    public class PrestamoServicio
    {
        private PrestamoMapper _mapper;
        List<Prestamo> _lstPrestamo;
        private ClienteServicio _clienteServicio;
        public PrestamoServicio()
        {
            _mapper = new PrestamoMapper();
            _lstPrestamo = _mapper.TraerPrestamos();
            _clienteServicio = new ClienteServicio();
        }

        public List<Prestamo> TraerTodosLosPrestamos()
        {
            return _lstPrestamo;
        }

        public List<Prestamo> TrearPretamosDeClientes()
        {
            List<Cliente> cli = _clienteServicio.TraerClientes();
            List<Prestamo> aux = new List<Prestamo>();

            foreach(Prestamo P in _lstPrestamo)
            {
                foreach(Cliente C in cli)
                {
                    if(C.Id == P.IdCliente)
                    {
                        aux.Add(P);
                    }
                }
            }
            return aux;
        }

        public int InsertarPrestamo(Prestamo P)
        {
            List<Prestamo> prestamos = _mapper.TraerPrestamos();

            foreach (Prestamo a in prestamos)
            {
                if(P.Id == a.Id)
                {
                    throw new Exception("Ya se encuentra un prestamo con ese numero de id.");
                }
            }

            TransactionResult resultado = _mapper.Insert(P);

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
