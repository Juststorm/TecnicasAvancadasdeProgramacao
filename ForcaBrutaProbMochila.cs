using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaBrutaMochila
{
    class Item
    {
        public int Peso { get; set; }
        public int Valor { get; set; }
        
        public Item(int peso, int valor)
        {
            Peso = peso;
            Valor = valor;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> itens = new List<Item>();
            itens.Add(new Item(12, 4));
            itens.Add(new Item(2, 2));
            itens.Add(new Item(1, 1));
            itens.Add(new Item(4, 10));
            itens.Add(new Item(1, 2));
            int Mochila = 15;

            ForcaBruta(itens, Mochila);

            Console.ReadKey();

        }

        static int ForcaBruta(List<Item> itens, int Mochila)
        {
            int totalItens = itens.Count;
            int Combinacoes = (int)Math.Pow(2, itens.Count);

            for (int i = 0; i < Combinacoes; i++)
            {
                string binario = Convert.ToString(i, 2);
                binario = binario.PadLeft(totalItens, '0');

                Console.WriteLine(totalItens + " - " + Combinacoes);

            }

            Console.WriteLine(totalItens + " - " + Combinacoes);

            return 0;
        }

    }
}
