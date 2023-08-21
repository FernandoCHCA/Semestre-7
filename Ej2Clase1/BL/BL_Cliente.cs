using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej2Clase1.Models;

namespace Ej2Clase1.BL
{
    public class BL_Cliente
    {
        /*static public List<string> Validaciones(DtoCliente PCliente)
        {
            List<string> LstValidaciones = new List<string>();

            *//*if (Validaciones(PCliente.Nombre))
            {

            }*//*
            //return LstValidaciones;

        }*/

        public Boolean Validadon(string PTexto)
        {
            Boolean Result = false;

            foreach (char Letra in PTexto.Replace(" ", ""))
            {
                if (!char.IsLetter(Letra))
                {
                    Result = true;
                    break;
                }
            }

            return Result;
        }

        public void Resultado(Boolean PNombre, Boolean PAPaterno, Boolean PAMaterno)
        {
            if (!PNombre && !PAPaterno && !PAMaterno)
            {
                Console.WriteLine("Se guardo el registro correctamente");
            }
            else
            {
                Console.WriteLine("Listado de errores\n");
                if (PNombre)
                {
                    Console.WriteLine("Revise el Nombre");
                }
                if (PAPaterno)
                {
                    Console.WriteLine("Revise el Apellido Paterno");
                }
                if (PAMaterno)
                {
                    Console.WriteLine("Revise el Apellido Materno");
                }
            }
        }

    }
}
