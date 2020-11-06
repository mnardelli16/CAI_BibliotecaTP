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

        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TraerTodos();  
                                                        
            return result;
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
