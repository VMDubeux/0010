using System;
namespace Exercicio
{
    class ProjetoDez
    {
        static void Main(string[] args)
        {
            sbyte alcool = 0;
            sbyte gasolina = 0;
            sbyte diesel = 0;

            Console.WriteLine("Informe o código do produto (1 a 3) ou digite 4 para finalizar:");
            sbyte cod = sbyte.Parse(Console.ReadLine());

            while (cod != 4)
            {
                if (cod == 1)
                {
                    alcool++;
                }
                else if (cod == 2)
                {
                    gasolina++;
                }
                else if (cod == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Código Inválido. Digite um código válido.");
                }
                Console.WriteLine("Informe o código de outro produto:");
                cod = sbyte.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Lista de produtos selecionados:");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina:{gasolina}");
            Console.WriteLine($"Diesel:{diesel}");
        }
    }
}