using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string contenido;
            string Condicion_1 = @"([a-z]|[A-z])+?.(com)+$";
            string Condicion_2 = @"(([a-z]|[A-Z])|[0-9])+?@([a-z]|[A-Z])+?.(com)+$";
            int op;
            Console.Write("1.Direccion web\n2.Correo electronico\n0.Salir\nQue desea hacer: ");
            op = int.Parse(Console.ReadLine());
            while (op!=0)
            {
                switch (op)
                {
                    case 1:
                        Console.Write("\n\nIngrese la direccion web:\n");
                        contenido = Console.ReadLine();
                        if (Regex.IsMatch(contenido, Condicion_1))
                        {
                            Console.Write("\nIngreso una direccion correcta\n\n");
                        }
                        else
                        {
                            Console.Write("\nIngreso una direccion incorrecta\n\n");
                        }
                        break;
                    case 2:
                        Console.Write("\n\nIngrese el correo electronico:\n");
                        contenido = Console.ReadLine();
                        if (Regex.IsMatch(contenido, Condicion_2))
                        {
                            Console.Write("\nIngreso una direccion correcta\n\n");
                        }
                        else
                        {
                            Console.Write("\nIngreso una direccion incorrecta\n\n");
                        }
                        break;
                }
                Console.Write("1.Direccion web\n2.Correo electronico\n0.Salir\nQue desea hacer: ");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
