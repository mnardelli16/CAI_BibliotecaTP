using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CAI_BibliotecaTP.Entidades;
using Newtonsoft.Json;

namespace CAI_BibliotecaTP.Datos
{
    public class ClienteMapper
    {
        string reg = ConfigurationManager.AppSettings["Legajo"];
        public List<Cliente> TraerTodos() // trae a todos los clientes que estan en el GET para nuestro REGISTRO
        {
            string json2 = WebHelper.Get("/cliente/" + reg);
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        private List<Cliente> MapList(string json) // MAPEO DE STRING DE LA WEB A UNA LISTA DE CLIENTES
        {
            List<Cliente> lista = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lista;
        }

        public TransactionResult Insert(Cliente C)
        {
            NameValueCollection obj = ReverseMap(C);              // serializo y transformo en un diccionario

            string result = WebHelper.Post("/cliente", obj);

            TransactionResult resultTransaccion = MapResultado(result);

            return resultTransaccion;
        }

        private NameValueCollection ReverseMap(Cliente C)
        {
            NameValueCollection obj = new NameValueCollection();
            obj.Add("Dni", C.Dni.ToString());
            obj.Add("Nombre",C.Nombre);
            obj.Add("Apellido", C.Apellido);
            obj.Add("Direccion", C.Direccion);
            obj.Add("Email", C.Email);
            obj.Add("Telefono", C.Telefono.ToString());
            obj.Add("FechaNacimiento", C.FechaNacimiento.ToShortDateString());
            obj.Add("Activo", C.Activo.ToString());
            obj.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);

            return obj;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

    }
}
