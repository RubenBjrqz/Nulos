﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro miCarro = new Carro();
            miCarro.Marca = "Tsuru";
            miCarro.Kilometraje = 100000;

            Console.WriteLine("Marca: " + miCarro.Marca);
            Console.WriteLine("KM: " + miCarro.Kilometraje);

            miCarro.DueñoCarro = new Dueño();
            miCarro.DueñoCarro.Nombre = "Pedro";
            miCarro.DueñoCarro = null;

            if(miCarro.DueñoCarro != null)
            {
                Console.WriteLine("Dueño: " + miCarro.DueñoCarro.Nombre);
            }
            else
            {
                Console.WriteLine("No se encontró dueño");
            }

            Console.ReadLine();
        }
    }
}
