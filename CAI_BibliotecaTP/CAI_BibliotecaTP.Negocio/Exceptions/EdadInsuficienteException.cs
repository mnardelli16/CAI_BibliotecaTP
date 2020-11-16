using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Negocio
{
    public class EdadInsuficienteException:Exception
    {
        public EdadInsuficienteException() : base("El cliete debe ser mayor de 18 años")
        {

        }
    }
}
