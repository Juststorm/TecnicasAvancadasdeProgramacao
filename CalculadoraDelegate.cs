using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDelegate
{
    class Program
    {
        public delegate int Calculos(int x, int y);
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static int Subtracao(int x, int y)
        {
            return x - y;
        }

        public static int Multiplicacao(int x, int y)
        {
            return x * y;
        }

        public static int Divisao(int x, int y)
        {
            return x / y;
        }


        static void Main(string[] args)
        {
            int Opcao;
            int v1, v2;

            Console.Write("Digite o valor 1: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2: ");
            v2 = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("VALOR 1 = {0}   VALOR 2 = {1}\n", v1, v2);
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair da Aplicação");
            Console.Write("\nDigite a operação desejada: ");
            Opcao = int.Parse(Console.ReadLine());

            switch (Opcao)
            {
                case 1:
                    Calculos FazSoma = new Calculos(Soma);
                    Console.WriteLine("{0} + {1} = {2}", v1, v2, FazSoma(v1, v2));
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case 2:
                    Calculos FazSub = new Calculos(Subtracao);
                    Console.WriteLine("{0} - {1} = {2}", v1, v2, FazSub(v1, v2));
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case 3:
                    Calculos FazMult = new Calculos(Multiplicacao);
                    Console.WriteLine("{0} x {1} = {2}", v1, v2, FazMult(v1, v2));
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case 4:
                    if (v2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0.");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                    }
                    else
                    {
                        Calculos FazDiv = new Calculos(Divisao);
                        Console.WriteLine("{0} / {1} = {2}", v1, v2, FazDiv(v1, v2));
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Função inválida para o menu.");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
            }

        }
    }
}
