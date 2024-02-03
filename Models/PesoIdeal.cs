using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Models
{
    public class PesoIdeal
    {
        public static void TelaPesoIdeal()
        {
            Console.WriteLine("========================[ Desafio 3]========================\n");

            string nome;
            char sexo;
            decimal peso, altura, resultado;

            try
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("\nDigite seu sexo: ");
                sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite seu peso: ");
                peso = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite seu altura: ");
                altura = decimal.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    resultado = (peso * altura) - 58.00m;
                    Console.WriteLine($"\n{nome} seu peso ideal é {resultado}");
                }
                else if (sexo == 'F')
                {
                    resultado = (peso * altura) - 44.70m;
                    Console.WriteLine($"\n{nome} seu peso ideal é {resultado}");
                }
                else
                {
                    Console.WriteLine("Sexo inválido!");
                }

                Menu.TelaMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                Console.Clear();

                TelaPesoIdeal();
            }
        }
    }
}
