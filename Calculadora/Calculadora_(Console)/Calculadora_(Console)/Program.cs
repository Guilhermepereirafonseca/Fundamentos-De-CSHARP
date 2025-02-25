using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("\t \t \t \t \t \t \tCALCULADORA\n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplição");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------");

            Console.WriteLine("Selecione uma opção: ");
            short result = short.Parse(Console.ReadLine());

            switch(result)
            {
                case 1: Soma();
                    break;
                case 2: Subtracao();
                    break; 
                case 3: Divisao(); 
                    break;
                case 4: Multiplicao();
                    break;
                case 5: System.Environment.Exit(0); // para fechar o terminal [0 = sair com sucesso]
                    break;
                default: Menu();
                    break;
            }
       }

        static void Soma() { 
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Result_Soma = n1 + n2;
            Console.WriteLine($"O resultado da soma é {Result_Soma}");
            Console.ReadKey();
            Menu();
        }
        
        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Result_Subtracao = n1 - n2;
            Console.WriteLine($"O resultado da subtração {Result_Subtracao}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Result_Divisao = n1 / n2;
            Console.WriteLine($"O resultado da divisao {Result_Divisao}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Result_Multiplicao = n1 * n2;
            Console.WriteLine($"O resultado da divisao {Result_Multiplicao}");
            Console.ReadKey();
            Menu();
        }
    }
}