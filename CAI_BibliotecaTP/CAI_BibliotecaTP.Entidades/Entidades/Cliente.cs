using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Entidades
{
    [DataContract]
    public class Cliente:Persona
    {
        private int _id;
        private DateTime _fechaAlta;
        private bool _activo;

        [DataMember]
        public int Id { get => this._id; set => this._id = value; }
        [DataMember]
        public DateTime FechaAlta { get => this._fechaAlta; set => this._fechaAlta = value; }
        [DataMember]
        public bool Activo { get => this._activo; set => this._activo = value; }

        public Cliente(int dni,string nombre, string apellido, string direccion, long telefono, string email, bool activo, string fechanacimiento)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
            this._direccion = direccion;
            this._telefono = telefono;
            this._email = email;
            this._fechaNacimiento = Convert.ToDateTime(fechanacimiento);
            this._activo = activo;

        }
        public override string ToString()
        {
            return string.Format("Cliente - {0} {1} {2}, DNI: {3}", this._id, this._apellido, this._nombre, this._dni);
        }

    }
}
