using System;

namespace AppProvaLogicProg_Exerc_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int QtdValoresInteiros;
            int[] ProximoValor;
            int InIntervalo = 0;
            int OutIntervalo = 0;

            Console.WriteLine("Digite um valor inteiro N:");
            QtdValoresInteiros = int.Parse(Console.ReadLine());
            
            ProximoValor = new int[QtdValoresInteiros];
            Console.WriteLine($"Digite os valores do seu array, que possui: {QtdValoresInteiros} posições.");

            for (int i = 0; i < QtdValoresInteiros; i++)
            {
                ProximoValor[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in ProximoValor)
            {
                if (item >=10 && item<=20)
                {
                    InIntervalo = InIntervalo + 1;
                }
                else
                {
                    OutIntervalo = OutIntervalo + 1;
                }
            }

            Console.WriteLine("Quantidade de números dentro e fora do intervalo de [10-20]");
            Console.WriteLine($"In: {InIntervalo}");
            Console.WriteLine($"Out: {OutIntervalo}");
            Console.ReadLine();
        }
    }
}
