using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaOrdemSelecao
{  
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<int, bool> selecao = (x) => x % 2 == 1;

            printResults(numeros, selecao);

            Console.ReadKey();
        }

        static void printResults(int[] numeros, Func<int, bool> selecao)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (selecao(numeros[i]))
                    Console.Write(" " + numeros[i]);
            }
        }

    }
}
