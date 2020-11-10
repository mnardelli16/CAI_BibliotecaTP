using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Entidades.Entidades
{
    [DataContract]
    public class Prestamo
    {
        private int _id;
        private int _idCliente;
        private int _idEjemplar;
        private int _plazo;
        private DateTime _fechaAlta;
        private DateTime _fechaBajaTentativa;
        private DateTime _fechaBajaReal;
        private bool _estado;

        public Prestamo(int IdCliente, int IdEjemplar, int Plazo, bool abierto, DateTime FechaAlta, DateTime FechaBaja )
        {
            //this._id = Id;
            this._idCliente = IdCliente;
            this._idEjemplar = IdEjemplar;
            this._plazo = Plazo;
            this._estado = abierto;
            this._fechaAlta = FechaAlta;
            this._fechaBajaTentativa = FechaAlta.AddDays(_plazo);
            this._fechaBajaReal = FechaBaja;
        }

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember]
        public int IdEjemplar { get => _idEjemplar; set => _idEjemplar = value; }
        [DataMember]
        public int Plazo { get => _plazo; set => _plazo = value; }
        [DataMember]
        public DateTime FechaPrestamo { get => _fechaAlta; set => _fechaAlta = value; }
        [DataMember]
        public DateTime FechaDevolucionTentativa { get => _fechaBajaTentativa; set => _fechaBajaTentativa = value; }
        [DataMember]
        public DateTime FechaDevolucionReal { get => _fechaBajaReal; set => _fechaBajaReal = value; }
        [DataMember]
        public bool Estado { get => _estado; set => _estado = value; }

        public override string ToString()
        {
            return string.Format($"Cliente: {_idCliente} - Ejemplar: {_idEjemplar} - Plazo: {_plazo} dias - Fecha de Prestamo: {_fechaAlta} - Fecha de devolucion estimada: {_fechaBajaTentativa} - Fecha de devolucion real {_fechaBajaReal}");
        }
    }
}
