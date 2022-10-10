using System;
namespace CALCULADORA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES
            int v1, v2, s, r;
            Console.WriteLine("INGRESE EL PRIMER NUMERO");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
            v2 = Convert.ToInt32(Console.ReadLine());
            //REALIZAR OPERACIONES
            s = v1 + v2;
            r = v1 - v2;
            //MOSTRAR RESULTADO
            Console.WriteLine($"LA OPERACION DE {v1} + {v2} ES :{s}");
            Console.WriteLine($"LA OPERACION DE {v1} - {v2} ES :{r}");


        }
    }
}
