using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Entidades.Entidades
{
    [DataContract]
    public class Ejemplar
    {
        private int _id;
        private int _idLibro;
        private string _obs;
        private double _precio;
        private DateTime _fechaAlta;
        public Ejemplar (int idlibro, string Observaciones, double Precio, DateTime FechaAlta)
        {
            this._idLibro = idlibro;
            this._obs = Observaciones;
            this._precio = Precio;
            this._fechaAlta = FechaAlta;
        }
        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public int IdLibro { get => _idLibro; set => _idLibro = value; }
        [DataMember]
        public string Observaciones { get => _obs; set => _obs = value; }
        [DataMember]
        public double Precio { get => _precio; set => _precio = value; }
        [DataMember]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public override string ToString()
        {
            return string.Format($"ID: {_id} - Observaciones: {_obs} - Precio: AR${_precio} - Fecha de Alta: {_fechaAlta}");
        }
    }
}
