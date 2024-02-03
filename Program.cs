namespace Desafios
{
    class Program
    {
        public static void Main(string[] args)
        {
            //    Console.WriteLine("========================[ Desafio 1]========================\n");

            //    int operacao, num1, num2, resultado;

            //    try
            //    {
            //        do
            //        {
            //            Console.WriteLine("Qual a operação deseja fazer: \n");
            //            Console.WriteLine("1 - Soma");
            //            Console.WriteLine("2 - Subtração");
            //            Console.WriteLine("3 - Multiplicação");
            //            Console.WriteLine("4 - Divisão");
            //            Console.WriteLine("0 - Sair\n");

            //            operacao = int.Parse(Console.ReadLine());
            //            Console.Clear();

            //            if (operacao >= 1 && operacao <= 4)
            //            {
            //                Console.WriteLine("\nDigite o primeiro número: ");
            //                num1 = int.Parse(Console.ReadLine());
            //                Console.WriteLine("\nDigite o segundo número: ");
            //                num2 = int.Parse(Console.ReadLine());

            //                switch (operacao)
            //                {
            //                    case 1:
            //                        resultado = num1 + num2;
            //                        Console.WriteLine($"\nO resultado da Soma: {num1} + {num2} = {resultado}");
            //                        break;
            //                    case 2:
            //                        resultado = num1 - num2;
            //                        Console.WriteLine($"\nO resultado da Subtração: {num1} - {num2} = {resultado}");
            //                        break;
            //                    case 3:
            //                        resultado = num1 * num2;
            //                        Console.WriteLine($"\nO resultado da Multiplicação: {num1} x {num2} = {resultado}");
            //                        break;
            //                    case 4:
            //                        resultado = num1 / num2;
            //                        Console.WriteLine($"\nO resultado da Divisão: {num1} / {num2} = {resultado}");
            //                        break;
            //                    default:
            //                        Console.WriteLine("\nDigite uma opção válida!");
            //                        break;
            //                }

            //                Console.WriteLine("\nOperação finalizada com sucesso!\n");
            //            }
            //            else if (operacao == 0)
            //            {
            //                Console.WriteLine("\nVocê saiu do sistema!");
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Digite uma opção válida!\n");
            //            }

            //        } while (operacao != 0);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.Clear();
            //        Console.WriteLine($"Ocorreu um erro na sua aplicação: {ex.Message}");
            //    }

            //Console.WriteLine("========================[ Desafio 2]========================\n");

            //int idade;

            //try
            //{
            //    Console.WriteLine("Digite sua idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (idade >= 5 && idade <= 7)
            //    {
            //        Console.WriteLine("Sua categoria é Infantil A");
            //    }
            //    else if (idade >= 8 && idade <= 11)
            //    {
            //        Console.WriteLine("Sua categoria é Infantil B");
            //    }
            //    else if (idade >= 12 && idade <= 13)
            //    {
            //        Console.WriteLine("Sua categoria é Juvenil A");
            //    }
            //    else if (idade >= 14 && idade <= 17)
            //    {
            //        Console.WriteLine("Sua categoria é Juvenil B");
            //    }
            //    else if (idade >= 18)
            //    {
            //        Console.WriteLine("Sua categoria é Adulto");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Você não pode participar do campeonato, pois, não tem idade suficiente!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.Clear();
            //    Console.WriteLine($"Ocorreu um erro na sua aplicação: {ex.Message}");
            //}

            //Console.WriteLine("========================[ Desafio 3]========================\n");

            //string nome;
            //char sexo;
            //decimal peso, altura, resultado;

            //try
            //{
            //    Console.WriteLine("Digite seu nome: ");
            //    nome = Console.ReadLine();

            //    Console.WriteLine("\nDigite seu sexo: ");
            //    sexo = char.Parse(Console.ReadLine());

            //    Console.WriteLine("\nDigite seu peso: ");
            //    peso = decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("\nDigite seu altura: ");
            //    altura = decimal.Parse(Console.ReadLine());

            //    if (sexo == 'M')
            //    {
            //        resultado = (peso * altura) - 58.00m;
            //        Console.WriteLine($"\n{nome} seu peso ideal é {resultado}");
            //    }
            //    else if (sexo == 'F')
            //    {
            //        resultado = (peso * altura) - 44.70m;
            //        Console.WriteLine($"\n{nome} seu peso ideal é {resultado}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sexo inválido!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.Clear();
            //    Console.WriteLine($"Ocorreu um erro na sua aplicação: {ex.Message}");
            //}

            //Console.WriteLine("========================[ Desafio 4]========================\n");

            //int opcao;
            //decimal valorEmReais, resultado;

            //try
            //{
            //    Console.WriteLine("Digite o valor em R$ que você quer converter: ");
            //    valorEmReais = decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("\n1 - Dólar");
            //    Console.WriteLine("2 - Euro");
            //    Console.WriteLine("3 - Libra");

            //    Console.WriteLine("\nDigite a opção de moeda que você quer converter: ");
            //    opcao = int.Parse(Console.ReadLine());

            //    switch (opcao)
            //    {
            //        case 1:
            //            resultado = valorEmReais / 4.93m;
            //            Console.WriteLine($"\nO valor da conversão é {resultado}");
            //            break;
            //        case 2:
            //            resultado = valorEmReais / 5.36m;
            //            Console.WriteLine($"\nO valor da conversão é {resultado}");
            //            break;
            //        case 3:
            //            resultado = valorEmReais / 6.26m;
            //            Console.WriteLine($"\nO valor da conversão é {resultado}");
            //            break;
            //        default:
            //            Console.WriteLine("Opção inválida! Tente novmanete");
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.Clear();
            //    Console.WriteLine($"Ocorreu um erro na sua aplicação: {ex.Message}");
            //}

            Console.WriteLine("========================[ Desafio 5]========================\n");

            int numero, total;
            try
            {
                Console.WriteLine("Digite um número da tabuada que deseja: ");
                numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"A tabuada do {numero}: \n");
                for (int i = 0; i <= 10; i++)
                {
                    total = numero * i;
                    Console.WriteLine($"{numero} x {i} = {total}");
                }

                Console.WriteLine("\nTabuada finalizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Ocorreu um erro na sua aplicação: {ex.Message}");
            }
        }
    }
}