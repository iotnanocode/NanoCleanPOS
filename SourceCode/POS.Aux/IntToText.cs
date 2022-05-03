using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.Aux
{
    class IntToText
    {
        string cantidad;
        string Unidadstring;
        string Decenastring;
        bool centbool;
        public IntToText()
        {
            cantidad = "";
            Unidadstring = "";
            Decenastring = "";
            centbool = false;
        }
        public string parse(string cantidadaconvertir)
        {
            cantidadaconvertir = cantidadaconvertir.Replace(",", ".");
            StringBuilder intpart = (cantidadaconvertir.IndexOf(".") > 0) ?
                new StringBuilder(cantidadaconvertir.Substring(0, cantidadaconvertir.IndexOf("."))) :
                new StringBuilder(cantidadaconvertir);

            string ParteDecimal = (cantidadaconvertir.IndexOf(".") > 0) ?cantidadaconvertir.Substring(cantidadaconvertir.IndexOf(".") + 1):"00";

            Unidadstring = unidades((intpart[intpart.Length - 1]).ToString());//primer digito de derecha a izquierda
            cantidad = Unidadstring;
            if (intpart.Length > 1)//segundo digito
            {
                Decenastring = decenas((intpart[intpart.Length - 2]).ToString(),
                (intpart[intpart.Length - 1]).ToString());
                cantidad = Decenastring + Unidadstring;
            }
            if (intpart.Length > 2)//tercer digito
            {
                cantidad = centenas((intpart[intpart.Length - 3]).ToString()) + Decenastring + Unidadstring;
                Unidadstring = "";
                Decenastring = "";
            }

            if (intpart.Length > 3)//cuarto digito
            {
                Unidadstring = unidadesdemillar((intpart[intpart.Length - 4]).ToString());
                if (intpart.Length == 4)//verifico que hasta ayi llegue
                    cantidad = Unidadstring + cantidad;
            }
            if (intpart.Length > 4)//quinto digito
            {
                Decenastring = decenasdemillar((intpart[intpart.Length - 5]).ToString(),
                (intpart[intpart.Length - 4]).ToString());
                cantidad = Decenastring + Unidadstring + cantidad;
            }
            if (intpart.Length > 5)//sexto digito o centenas de millar
            {
                string tem = centenas((intpart[intpart.Length - 6]).ToString());
                cantidad = (centbool) ? tem + "MIL " + cantidad : tem + cantidad;
                Unidadstring = "";
                Decenastring = "";
                centbool = false;
            }
            if (intpart.Length > 6)//septimo digito millones
            {
                Unidadstring = unidadesdemillon((intpart[intpart.Length - 7]).ToString());
                if (intpart.Length == 7)
                    cantidad = Unidadstring + cantidad;
            }
            if (intpart.Length > 7)//octavo digito decenas de millones
            {
                Decenastring = decenasdemillon((intpart[intpart.Length - 8]).ToString(),
                (intpart[intpart.Length - 7]).ToString());
                cantidad = Decenastring + Unidadstring + cantidad;
            }
            if (intpart.Length > 8)//noveno digito o centenas de millones
            {
                string tem = centenas((intpart[intpart.Length - 9]).ToString());
                cantidad = (centbool) ? tem + "MILLONES " + cantidad : tem + cantidad;
                Unidadstring = "";
                Decenastring = "";
                centbool = false;
            }

            ParteDecimal = ParteDecimal.Length < 2 ? ParteDecimal + "0" : ParteDecimal;
            cantidad += " PESOS " + ParteDecimal + "/100 M.N.";
            return cantidad;
        }

        string unidades(string unidad)
        {
            int NUM = Int32.Parse(unidad);
            string[] letras = { "", "UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            return letras[NUM];
        }
        string decenas(string decena, string unidad)
        {
            int dec, uni;
            dec = Int32.Parse(decena);
            uni = Int32.Parse(unidad);
            string cant;
            if (dec == 1 && uni < 6)
            {
                string[] letras = { "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE" };
                Unidadstring = "";
                cant = letras[uni];
            }
            else if (dec == 1 && uni >= 6)
                cant = "DIEZ Y ";
            else
            {
                string[] letras = { "", "", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
                cant = letras[dec];
                if (uni >= 1)
                    cant += " Y ";

            }

            return cant;
        }
        string centenas(string centena)
        {
            centbool = false;
            int cen = Int32.Parse(centena);
            string cant = "";
            if (cen == 1)
            {
                if (Unidadstring == "" && Decenastring == "")
                {
                    cant = "CIEN ";
                    centbool = true;
                }
                else
                    cant = "CIENTO ";
            }
            if (cen > 1)
            {
                if (cen != 5)
                {
                    cant = unidades(centena);
                    cant += " CIENTOS ";
                }
                else
                    cant = "QUINIENTOS ";
                if (Unidadstring == "")
                    centbool = true;
            }
            return cant;
        }
        string unidadesdemillar(string numero)
        {
            int num = Int32.Parse(numero);
            string cant = "";
            if (num == 1)
                cant = "UN";
            if (num > 1)
                cant += unidades(numero);
            if (num >= 1)
                cant += " MIL ";
            return cant;
        }
        string decenasdemillar(string decena, string unidad)
        {
            string cant = "";
            if (decena != "0")
            {
                cant = decenas(decena, unidad);
                //if (Int32.Parse(unidad) < 6&&Int32.Parse(decena)==1)
                if (Unidadstring == "")
                    Unidadstring = " MIL ";

            }
            return cant;
        }
        string unidadesdemillon(string unidad)
        {
            string cant = "";
            cant = unidades(unidad);
            if (Int32.Parse(unidad) == 1)
                cant += " MILLON ";
            if (Int32.Parse(unidad) > 1)
                cant += " MILLONES ";
            return cant;
        }
        string decenasdemillon(string decena, string unidad)
        {
            string cant = "";
            if (decena != "0")
            {
                cant = decenas(decena, unidad);
                //if (Int32.Parse(unidad) < 6 && Int32.Parse(decena) == 1)
                if (Unidadstring == "")
                    Unidadstring = " MILLLONES ";
            }
            return cant;
        }
    }
}
