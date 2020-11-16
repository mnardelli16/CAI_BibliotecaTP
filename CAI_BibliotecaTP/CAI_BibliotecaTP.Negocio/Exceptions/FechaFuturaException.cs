using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Negocio.Exceptions
{
    public class FechaFuturaException:Exception
    {
        public FechaFuturaException():base("La fecha ingresada no puede ser mayor a hoy")
        {

        }
    }
}
