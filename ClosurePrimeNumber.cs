using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 6.	Crie um programa que use Closures para gerar a sequência (números) Primos. 
 * Em seu programa você deve criar um função, usando closure, que a cada chamada gere o próximo número primo da sequência.
*/
namespace Primo
{
    class Program
    {

        static Action CalcPrimo()
        {
            int n = 0;

            Action primo = () =>
            {
                bool isPrimo = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrimo = false;
                    }
                }
                if (isPrimo)
                    Console.WriteLine(n);
                n++;
            };

            return primo;

        }
        static void Main(string[] args)
        {
            Action PrimoNovo = CalcPrimo();

            for (int i = 0; i < 110; i++)
            {
                PrimoNovo();
            }

            Console.ReadKey();
        }
    }
}
