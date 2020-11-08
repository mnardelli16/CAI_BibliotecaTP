using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAI_BibliotecaTP.Entidades.Entidades;
using CAI_BibliotecaTP.Entidades;
using CAI_BibliotecaTP.Datos;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Negocio
{
    public class EjemplarServicio
    {
        private EjemplarMapper _mapper;

        public EjemplarServicio()
        {
            _mapper = new EjemplarMapper();
        }

        public List<Ejemplar> TraerEjemplares()
        {
            List<Ejemplar> lista = _mapper.TraerEjemplares();

            return lista;
        }

        public int InsertarEjemplar(Ejemplar e)
        {
            List<Ejemplar> ejemplares = _mapper.TraerEjemplares();

            foreach(Ejemplar a in ejemplares)
            {
                if(e.Id == a.Id)
                {
                    throw new Exception("Ya existe un ejemplar cargado con ese numero de Id.");
                }
            }

            TransactionResult result = _mapper.Insert(e);

            if (!result.IsOk)
            {
                throw new Exception("Hubo un error en la peticion al servidor. Detalle: " + result.Error);
            }
            else
            {
                return result.Id;
            }
        }
    }
}
