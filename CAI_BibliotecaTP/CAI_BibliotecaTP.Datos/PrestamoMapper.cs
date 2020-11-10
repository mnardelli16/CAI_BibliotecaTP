﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using CAI_BibliotecaTP.Entidades.Entidades;
using CAI_BibliotecaTP.Entidades;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Specialized;
using System.Configuration;

namespace CAI_BibliotecaTP.Datos
{
    public class PrestamoMapper
    {
        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> prestamos = JsonConvert.DeserializeObject<List<Prestamo>>(json);

            return prestamos;
        }

        public List<Prestamo> TraerPrestamos()
        {
            string json = WebHelper.Get("/Biblioteca/Prestamos");
            List<Prestamo> prestamos = MapList(json);

            return prestamos;
        }

        private NameValueCollection ReverseMap(Prestamo P)
        {
            NameValueCollection obj = new NameValueCollection();

            obj.Add("idCliente", P.IdCliente.ToString());
            obj.Add("idEjemplar", P.IdEjemplar.ToString());
            obj.Add("Plazo", P.Plazo.ToString());
            obj.Add("Abierto", P.Estado.ToString());
            obj.Add("FechaPrestamo", P.FechaPrestamo.ToShortDateString());
            obj.Add("FechaDevolucionTentativa", P.FechaDevolucionTentativa.ToShortDateString());
            obj.Add("FechaDevolucionReal", P.FechaDevolucionReal.ToShortDateString());
            //obj.Add("id", P.Id.ToString());

            return obj;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult obj = JsonConvert.DeserializeObject<TransactionResult>(json);
            return obj;
        }

        public TransactionResult Insert(Prestamo P)
        {
            NameValueCollection obj = ReverseMap(P);

            string ruta = WebHelper.Post("/Biblioteca/Prestamos", obj);
            TransactionResult resultadoTransc = MapResultado(ruta);

            return resultadoTransc;
        }
    }
}
