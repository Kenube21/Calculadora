using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=0, num2=0;
            bool salir = false;
            do {
                Console.WriteLine("1.sumar");
                Console.WriteLine("2.resta");
                Console.WriteLine("3.division");
                Console.WriteLine("4.potencia");
                Console.WriteLine("5.area triangulo");
                Console.WriteLine("6.area cuadrado");
                Console.WriteLine("7.salir");

                string opcion= Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Primer numero");
                        num1= int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La suma es: {num1 + num2}");
                        break;
                    case "2":
                        Console.WriteLine("Primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La resta es: {num1 - num2}");
                        break;
                    case "3":
                        Console.WriteLine("Primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La division es: {num1 / num2}");
                        break;
                    case "4":
                        Console.WriteLine("Primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La potencia es: {num1 ^ num2}");
                        break;
                    case "5":
                        Console.WriteLine("Primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"El area del triangulo es: {(num1 * num2)/2}");
                        break;
                    case "6":
                        Console.WriteLine("Primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La potencia es: {num1 * num2}");
                        break ;
                    case "7":
                        Console.WriteLine("Saliendo");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion correcta");
                        break;
                }
            }
            while (!salir);


        }
    }
}
