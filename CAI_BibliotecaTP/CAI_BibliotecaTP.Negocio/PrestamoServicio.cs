using CAI_BibliotecaTP.Datos;
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
        public PrestamoServicio()
        {
            _mapper = new PrestamoMapper();
        }

        public List<Prestamo> TraerTodosLosPrestamos()
        {
            List<Prestamo> prestamos = _mapper.TraerPrestamos();
            return prestamos;
        }
    }
}
