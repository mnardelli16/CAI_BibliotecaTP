using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Entidades
{
    public abstract class Persona
    {

        protected int _dni;
        protected string _nombre;
        protected string _apellido;
        protected string _direccion;
        protected long _telefono;
        protected string _email;
        protected DateTime _fechaNacimiento;

        public int Dni { get => this._dni; set => this._dni = value; }
        public string Nombre { get => this._nombre; set => this._nombre = value; }
        public string Apellido { get => this._apellido; set => this._apellido = value; }
        public string Direccion { get => this._direccion; set => this._direccion = value; }
        public long Telefono { get => this._telefono; set => this._telefono = value; }
        public string Email { get => this._email; set => this._email = value; }
        public DateTime FechaNacimiento { get => this._fechaNacimiento; set => this._fechaNacimiento = value; }


    }
}
