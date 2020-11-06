using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Entidades.Entidades
{
    [DataContract]
    public class Libro
    {
        private int _id;
        private string _titulo;
        private string _autor;
        private int _editorial;
        private int _paginas;
        private string _tema;

        public Libro(int Id, string Titulo, string Autor, int Editorial, int Paginas, string Tema)
        {
            this._id = Id;
            this._titulo = Titulo;
            this._autor = Autor;
            this._editorial = Editorial;
            this._paginas = Paginas;
            this._tema = Tema;
        }

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public string Titulo { get => _titulo; set => _titulo = value; }
        [DataMember]
        public string Autor { get => _autor; set => _autor = value; }
        [DataMember]
        public int Editorial { get => _editorial; set => _editorial = value; }
        [DataMember]
        public int Paginas { get => _paginas; set => _paginas = value; }
        [DataMember]
        public string Tema { get => _tema; set => _tema = value; }
    }
}
