﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_02_02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ingreso de datos
            Console.WriteLine("Ingrese del valor de la hipotenusa del triangulo rectangulo >>");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese del valor del angulo formado por la hipotenusa y el cateto mayor\n(Debe ser menor o igual a 45°) >>");
            double a = double.Parse(Console.ReadLine());

            if (a <= 45)
            {
                // Operaciones Matematicas
                double z = Math.Round(t * Math.Cos(Math.PI * a / 180), 2);
                double y = Math.Round(t * Math.Sin(Math.PI * a / 180), 2);
                double c = Math.Round(90 - a, 2);


                // Salida de datos
                Console.WriteLine("El valor del cateto mayor es >> " + z);
                Console.WriteLine("El valor del cateto menor es >> " + y);
                Console.WriteLine("El angulo formado por la hipotenusa y el cateto menor es >> " + c);
            }
            else
            {
                Console.WriteLine("El angulo debe ser menor o igual a 45°!");
            }
        }
    }
}
