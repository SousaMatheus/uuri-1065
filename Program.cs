using System;

namespace URI_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());
            
            int valoresPares = 0;

            if (valor1 %2 == 0){
                valoresPares += 1;
            }
            if (valor2 %2 == 0){
                valoresPares += 1;
            }
            if (valor3 %2 == 0){
                valoresPares += 1;
            }
            if (valor4 %2 == 0){
                valoresPares += 1;
            }
            if (valor5 %2 == 0){
                valoresPares += 1;
            }
            Console.WriteLine(valoresPares + " valores pares");
        }
    }
}
