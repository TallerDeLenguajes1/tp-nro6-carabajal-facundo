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
            float num_a, num_b, result;
            int op;
            Console.Write("1.sumar\n2.restar\n3.multiplicar\n4.dividir\n");
            Console.Write(".5.valor absoluot\n6.calcular cuadrado\n7.calcular raiz\n8.calcular ceno\n9.calcular coseno\n10.obtener entero\n0.salir\n\n");
            op = int.Parse(Console.ReadLine());
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write("digite el siguiente numero: ");
                        num_b = float.Parse(Console.ReadLine());
                        result = num_a + num_b;
                        Console.Write($"el resultado: {result}");
                        Console.Write("\n\n");

                        break;
                    case 2:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write("digite el siguiente numero: ");
                        num_b = float.Parse(Console.ReadLine());
                        result = num_a - num_b;
                        Console.Write($"el resultado: {result}");
                        Console.Write("\n\n");

                        break;
                    case 3:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write("digite el siguiente numero: ");
                        num_b = float.Parse(Console.ReadLine());
                        result = num_a * num_b;
                        Console.Write($"el resultado: {result}");
                        Console.Write("\n\n");

                        break;
                    case 4:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write("digite el siguiente numero: ");
                        num_b = float.Parse(Console.ReadLine());
                        result = num_a / num_b;
                        Console.Write($"el resultado: {result}");
                        Console.Write("\n\n");
                        break;
                    case 5:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        result = Math.Abs(num_a);
                        Console.Write($"el resultado: {result}");
                        Console.Write("\n\n");

                        break;
                    case 6:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write($"el resultado: {Math.Pow(num_a,2)}");
                        Console.Write("\n\n");

                        break;
                    case 7:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write($"el resultado: {Math.Sqrt(Convert.ToSingle(num_a))}");
                        Console.Write("\n\n");

                        break;
                    case 8:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write($"el resultado: {Math.Sin(Convert.ToSingle(num_a))}");
                        Console.Write("\n\n");

                        break;
                    case 9:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write($"el resultado: {Math.Cos(Convert.ToSingle(num_a))}");
                        Console.Write("\n\n");
                        break;
                    case 10:
                        Console.Write("digite un numero: ");
                        num_a = float.Parse(Console.ReadLine());
                        Console.Write($"el resultado: {Math.Round(num_a)}");
                        Console.Write("\n\n");
                        break;
                }
                Console.Write("1.sumar\n2.restar\n3.multiplicar\n4.dividir\n");
                Console.Write(".5.valor absoluot\n6.calcular cuadrado\n7.calcular raiz\n8.calcular ceno\n9.calcular coseno\n10.obtener entero\n0.salir\n\n");
                op = int.Parse(Console.ReadLine());
            }
        }
        //static public tipo_funcion num_fun (){CONTENIDO DE LA FUNCION}
    }
}
