﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Ingreso de datos
            Console.WriteLine("Ingrese del valor de cateto (Y) del triangulo rectangulo >>");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese del valor de cateto (Z) del triangulo rectangulo >>");
            double z = double.Parse(Console.ReadLine());

            // Operaciones Matematicas
            double t = Math.Round(Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2)),2);
            double c = Math.Round(Math.Atan(z / y) * (180 / Math.PI),2);
            double a = Math.Round(Math.Atan(y / z) * (180 / Math.PI),2);

            
            // Salida de datos
            Console.WriteLine("La hipotenusa del Triangulo Rectangulo es >> " + t );
            Console.WriteLine("El angulo que forma (Y) con la hipotenusa es >> " + c );
            Console.WriteLine("El angulo que forma (Z) con la hipotenusa es >> " + a );


        }
    }
}
