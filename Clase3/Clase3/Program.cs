﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea2");
            Console.ReadKey();

            /*Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se
            puede hacer dividiendo varias veces entre 10).*/


            int contador = 0;

            Console.WriteLine("Ingrese un número: ");

            int numeroElegido = Int32.Parse(Console.ReadLine());
            int numeroCiclo = numeroElegido;

            while (numeroCiclo > 0)
            {
                numeroCiclo = numeroCiclo / 10;

                contador++;

            }
            Console.WriteLine("el número {0} tiene {1} dígitos", numeroElegido, contador);
            Console.ReadKey();
        }
    }
}
