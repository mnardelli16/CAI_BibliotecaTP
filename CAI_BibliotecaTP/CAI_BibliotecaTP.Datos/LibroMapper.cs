using CAI_BibliotecaTP.Entidades;
using CAI_BibliotecaTP.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Datos
{
    public class LibroMapper
    {
        public List<Libro> TraerTodosLosLibros()
        {
            string json = WebHelper.Get("/Biblioteca/Libros");
            List<Libro> resulado = MapList(json);
            return resulado;
        }

        private List<Libro> MapList(string json)  
        {
            List<Libro> lista = JsonConvert.DeserializeObject<List<Libro>>(json);
            return lista;
        }

        public TransactionResult Insert(Libro L)
        {
            NameValueCollection obj = ReverseMap(L);              // serializo y transformo en un diccionario

            string result = WebHelper.Post("/Biblioteca/Libros", obj);

            TransactionResult resultTransaccion = MapResultado(result);

            return resultTransaccion;
        }

        private NameValueCollection ReverseMap(Libro L)
        {
            NameValueCollection obj = new NameValueCollection();

            obj.Add("Edicion", L.Edicion.ToString());
            obj.Add("Paginas", L.Paginas.ToString());
            obj.Add("Titulo", L.Titulo);
            obj.Add("Autor", L.Autor);
            obj.Add("Editorial", L.Editorial);
            obj.Add("Tema", L.Tema);

            return obj;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
