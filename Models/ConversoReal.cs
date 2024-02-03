using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Models
{
    public class ConversoReal
    {
        public static void TelaConversoReal()
        {
            Console.WriteLine("========================[ Desafio 4]========================\n");

            int opcao;
            decimal valorEmReais, resultado;

            try
            {
                Console.WriteLine("Digite o valor em R$ que você quer converter: ");
                valorEmReais = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\n1 - Dólar");
                Console.WriteLine("2 - Euro");
                Console.WriteLine("3 - Libra");

                Console.WriteLine("\nDigite a opção de moeda que você quer converter: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        resultado = valorEmReais / 4.93m;
                        Console.WriteLine($"\nO valor da conversão é {resultado}");
                        break;
                    case 2:
                        resultado = valorEmReais / 5.36m;
                        Console.WriteLine($"\nO valor da conversão é {resultado}");
                        break;
                    case 3:
                        resultado = valorEmReais / 6.26m;
                        Console.WriteLine($"\nO valor da conversão é {resultado}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novmanete");
                        break;
                }

                Menu.TelaMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                Console.Clear();

                TelaConversoReal();
            }
        }
    }
}
