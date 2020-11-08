using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAI_BibliotecaTP.Entidades.Entidades;
using CAI_BibliotecaTP.Entidades;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Configuration;

namespace CAI_BibliotecaTP.Datos
{
    public class EjemplarMapper
    {
        string reg = ConfigurationManager.AppSettings["Legajo"];
        private List<Ejemplar> MapList (string json)
        {
            List<Ejemplar> ejemplares = JsonConvert.DeserializeObject<List<Ejemplar>>(json);
            return ejemplares;
        }
        public List<Ejemplar> TraerEjemplares()
        {
            string json = WebHelper.Get("/Biblioteca/Ejemplares");
            List<Ejemplar> result = MapList(json);
            return result;
        }
        
        private NameValueCollection ReverseMap(Ejemplar e)
        {
            NameValueCollection obj = new NameValueCollection(); 
                                                                    //Revisar si esta bien el mappeo con los tipos de datos
            obj.Add("idLibro", e.IdLibro.ToString());
            obj.Add("Observaciones", e.Observaciones.ToString());
            obj.Add("Precio", e.Precio.ToString());
            obj.Add("FechaAlta", e.FechaAlta.ToString());
            obj.Add("id", e.Id.ToString());

            return obj;
        }

        private TransactionResult MapResultado (string json)
        {
            TransactionResult lista = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lista;
        }

        public TransactionResult Insert (Ejemplar e)
        {
            NameValueCollection obj = ReverseMap(e);

            string resultado = WebHelper.Post("/Biblioteca/Ejemplares", obj);

            TransactionResult resultTrans = MapResultado(resultado);

            return resultTrans;

        }

    }
}
