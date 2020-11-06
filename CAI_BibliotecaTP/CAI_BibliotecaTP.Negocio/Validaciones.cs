﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_BibliotecaTP.Negocio
{
    public static class Validaciones
    {
        public static string ValidarNumero(string num, string campo, ref int salida)
        {
            string msj;

            if (!Int32.TryParse(num, out salida))
            {
                msj = "El campo " + campo + " debe ingresar un valor numerico" + Environment.NewLine;
            }
            else if (salida <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo" + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;

        }
        public static string ValidarSTRING(string dato, string campo)
        {
            string msj;

            if (string.IsNullOrWhiteSpace(dato))
            {
                msj = "El campo " + campo + " no debe estar vacio" + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;

        }
        public static string ValidarSaldo(string num, string campo, ref float salida)
        {
            string msj;

            if (!float.TryParse(num, out salida))
            {
                msj = "El campo " + campo + " debe ingresar un valor numerico" + Environment.NewLine;
            }
            else if (salida <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo" + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;

        }

        public static string ValidarTelefono(string telef, string campo, ref long telefono)
        {
            string msj;

            if (!long.TryParse(telef, out telefono))
            {
                msj = "El campo " + campo + " debe ser un valor numerico" + Environment.NewLine;
            }
            else if (telefono <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo" + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;
        }
    }
}
