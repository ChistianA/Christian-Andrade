﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de datos
            Console.WriteLine("Ingrese del valor del cateto mayor del Triangulo Rectangulo >>");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese del valor del angulo formado por la hipotenusa y el cateto menor\n(Debe ser mayor o igual a 45°) >>");
            double c = double.Parse(Console.ReadLine());

            if(c >= 45)
            {
                // Operaciones Matematicas
                double t = Math.Round(z / Math.Sin(Math.PI * c / 180), 2);
                double y = Math.Round(z / Math.Tan(Math.PI * c / 180), 2);
                double a = Math.Round(90 - c, 2);


                // Salida de datos
                Console.WriteLine("El valor del cateto menor es >> " + y);
                Console.WriteLine("El valor de la hipotenusa es >> " + t);
                Console.WriteLine("El angulo formado por la hipotenusa y el cateto mayor es >> " + a);
            }
            else
            {
                Console.WriteLine("El angulo debe ser mayor o igual a 45°!");
            }
        }
    }
}
