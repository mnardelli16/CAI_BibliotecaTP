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
        private int _edicion;
        private string _editorial;
        private int _paginas;
        private string _tema;

        public Libro(string titulo, string autor, int edicion, string editorial, int paginas, string tema)
        {
            //this._id = id;
            this._titulo = titulo;
            this._autor = autor;
            this._edicion = edicion;
            this._editorial = editorial;
            this._paginas = paginas;
            this._tema = tema;
        }

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public string Titulo { get => _titulo; set => _titulo = value; }
        [DataMember]
        public string Autor { get => _autor; set => _autor = value; }
        [DataMember]
        public int Edicion { get => _edicion; set => _edicion = value; }
        [DataMember]
        public string Editorial { get => _editorial; set => _editorial = value; }
        [DataMember]
        public int Paginas { get => _paginas; set => _paginas = value; }
        [DataMember]
        public string Tema { get => _tema; set => _tema = value; }

        public override string ToString()
        {
            return string.Format("ID: {0} - Titulo: {1} - Autor: {2} - Editorial: {3} - Edicion: {4} - Paginas: {5} - Tema: {6}", this._id, this._titulo, this._autor,this._editorial,this._edicion,this._paginas,this._tema); 
        }
    }
}
