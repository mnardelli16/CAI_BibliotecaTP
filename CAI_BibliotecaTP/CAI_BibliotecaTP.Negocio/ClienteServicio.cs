using CAI_BibliotecaTP.Datos;
using CAI_BibliotecaTP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;
        private List<Cliente> _lstClientes;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
            _lstClientes = mapper.TraerTodos();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = _lstClientes;
                                                        
            return result;
        }

        public Cliente TraerClientePorID(int id)
        {
             return _lstClientes.Find(z => z.Id == id);
        }
        public Cliente TraerClientePorDNI(int dni)
        {
            return _lstClientes.Find(z => z.Dni == dni);
        }
        public List<Cliente> TraerNombreClientePorID(int id)
        {
            List<Cliente> aux = new List<Cliente>();

            foreach(Cliente B in _lstClientes)
            {
                if(B.Id == id)
                {
                    aux.Add(B);
                }
            }

            return aux;

        }

        public int InsertarCliente(Cliente cli)
        {
            List<Cliente> result = mapper.TraerTodos();

            foreach (Cliente C in result) // valida el negocio que no este ya cargado
            {
                if (cli.Dni == C.Dni)
                {
                    throw new Exception("El cliente ya existe");
                }
            }

            TransactionResult resultado = mapper.Insert(cli);

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
