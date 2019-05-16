using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "esto es una cadena de caracteres";
            string cad_aux=cadena.Substring(0,0);
            int a=0,b = 0;
            Console.Write("algunos elementos de la cadena de caracteres:\n");
            while ( a < 4)
            {
                cad_aux = cadena.Substring(a,b);
                Console.Write(cad_aux);
                a++;
                b++;
            }
            cad_aux += cadena;
            Console.Write($"\nLongitud de la cadena: {Convert.ToString(cadena.Length)}");
            Console.Write($"\n\ncadenas concatenadas:\n{cad_aux}\n");
            Console.Write("elementos de la cadena de caracteres:\n");
            foreach (char elemento in cadena)
            {
                Console.Write($"  {elemento}");
            }
            cad_aux = cadena;
            Console.Write($"\n\nCadena a mayuscula:\n{cad_aux.ToUpper()}");
            Console.Write($"\n\nCadena a minuscula:\n{cad_aux.ToLower()}");
            string [] arreglo = cadena.Split('e');
            Console.Write("\nCadena de caracter sacando la letra 'e':\n");
            for (int cont=0;cont<arreglo.Length;cont++)
            {
                Console.Write(arreglo[cont]);
            }
            int op;
            float num_a, num_b, result;
            string operacion;
            Console.Write("\n\n||-- CALCULADORA --||\n");
            Console.Write("1.sumar\n2.restar\n3.multiplicar\n4.dividir\n0.salir\n");
            op = int.Parse(Console.ReadLine());
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        Console.Write("digite la operacion: ");
                        operacion=Console.ReadLine();
                        arreglo = operacion.Split('+');
                        num_a = float.Parse(arreglo[0]);
                        num_b = float.Parse(arreglo[1]);
                        result = num_a + num_b;
                        Console.Write($"La suma de {num_a} y {num_b} es: {result}");
                        Console.Write("\n\n");

                        break;
                    case 2:
                        Console.Write("digite la operacion: ");
                        operacion = Console.ReadLine();
                        arreglo = operacion.Split('-');
                        num_a = float.Parse(arreglo[0]);
                        num_b = float.Parse(arreglo[1]);
                        result = num_a - num_b;
                        Console.Write($"La resta de {num_a} y {num_b} es: {result}");
                        Console.Write("\n\n");

                        break;
                    case 3:
                        Console.Write("digite la operacion: ");
                        operacion = Console.ReadLine();
                        arreglo = operacion.Split('*');
                        num_a = float.Parse(arreglo[0]);
                        num_b = float.Parse(arreglo[1]);
                        result = num_a * num_b;
                        Console.Write($"El producto de {num_a} y {num_b} es: {result}");
                        Console.Write("\n\n");

                        break;
                    case 4:
                        Console.Write("digite la operacion: ");
                        operacion = Console.ReadLine();
                        arreglo = operacion.Split('/');
                        num_a = float.Parse(arreglo[0]);
                        num_b = float.Parse(arreglo[1]);
                        result = num_a / num_b;
                        Console.Write($"La divicion de {num_a} y {num_b} es: {result}");
                        Console.Write("\n\n");
                        break;
                }
                Console.Write("1.sumar\n2.restar\n3.multiplicar\n4.dividir\n0.salir\n");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
