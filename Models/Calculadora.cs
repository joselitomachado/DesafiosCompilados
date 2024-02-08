namespace Desafios.Models
{
    public class Calculadora
    {
        public static void TelaCalculadora()
        {
            Console.WriteLine("========================[ Desafio 1]========================\n");

            int operacao, num1, num2, resultado;

            try
            {
                do
                {
                    Console.WriteLine("Qual a operação deseja fazer: \n");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("5 - Voltar\n");

                    operacao = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (operacao >= 1 && operacao <= 4)
                    {
                        Console.WriteLine("\nDigite o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        switch (operacao)
                        {
                            case 1:
                                resultado = num1 + num2;
                                Console.WriteLine($"\nO resultado da Soma: {num1} + {num2} = {resultado}");
                                break;
                            case 2:
                                resultado = num1 - num2;
                                Console.WriteLine($"\nO resultado da Subtração: {num1} - {num2} = {resultado}");
                                break;
                            case 3:
                                resultado = num1 * num2;
                                Console.WriteLine($"\nO resultado da Multiplicação: {num1} x {num2} = {resultado}");
                                break;
                            case 4:
                                resultado = num1 / num2;
                                Console.WriteLine($"\nO resultado da Divisão: {num1} / {num2} = {resultado}");
                                break;
                            default:
                                Console.WriteLine("\nDigite uma opção válida!");
                                break;
                        }

                        Console.WriteLine("\nOperação finalizada com sucesso!\n");
                    }
                    else if (operacao == 5)
                    {
                        Menu.TelaMenu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite uma opção válida!\n");
                    }

                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Clear();

                TelaCalculadora();
            }
        }
    }
}