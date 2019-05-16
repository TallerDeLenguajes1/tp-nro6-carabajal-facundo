using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, num_a, num_b, result;
            Console.Write("1.sumar\n2.restar\n3.multiplicar\n4.dividir\n0.salir\n\n");
            op = int.Parse(Console.ReadLine());
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        Console.Write("digite un numero: ");
                        num_a = int.Parse(Console.ReadLine());
                        Console.Write("digite el siguiente numero: ");
                        num_b = int.Parse(Console.ReadLine());
                        result = num_a + num_b;
                        Console.Write("el resultado: ");
                        Console.Write(result);
                        Console.Write("\n\n");

                        break;
                    case 2:
                        Console.Write("digite un numero: ");
                        num_a = int.Parse(Console.ReadLine());
                        Console.Write("digite el siguiente numero: ");
                        num_b = int.Parse(Console.ReadLine());
                        result = num_a - num_b;
                        Console.Write("el resultado: ");
                        Console.Write(result);
                        Console.Write("\n\n");

                        break;
                    case 3:
                        Console.Write("digite un numero: ");
                        num_a = int.Parse(Console.ReadLine());
                        Console.Write("digite el siguiente numero: ");
                        num_b = int.Parse(Console.ReadLine());
                        result = num_a * num_b;
                        Console.Write("el resultado: ");
                        Console.Write(result);
                        Console.Write("\n\n");

                        break;
                    case 4:
                        Console.Write("digite un numero: ");
                        num_a = int.Parse(Console.ReadLine());
                        Console.Write("digite el siguiente numero: ");
                        num_b = int.Parse(Console.ReadLine());
                        result = num_a / num_b;
                        Console.Write("el resultado: ");
                        Console.Write(result);
                        Console.Write("\n\n");

                        break;
                }
                Console.Write("1.sumar\n2.restar\n3.multiplicar\n4.dividir\n0.salir\n");
                op = int.Parse(Console.ReadLine());
            }
        }
        //static public tipo_funcion num_fun (){CONTENIDO DE LA FUNCION}
    }
}
