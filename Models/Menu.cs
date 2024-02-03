namespace Desafios.Models
{
    public class Menu
    {
        public static void TelaMenu()
        {
            Console.WriteLine("========================[ Menu ]========================\n");

            Console.WriteLine("Digite a opção desejada: \n");

            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Categoria Natação");
            Console.WriteLine("3 - Peso Ideal");
            Console.WriteLine("4 - Conversor Real");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Media Aluno");
            Console.WriteLine("7 - Sair");
            try
            {
                int opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Calculadora.TelaCalculadora();
                        break;
                    case 2:
                        NatacaoIdade.TelaNatacaoIdade();
                        break;
                    case 3:
                        PesoIdeal.TelaPesoIdeal();
                        break;
                    case 4:
                        ConversoReal.TelaConversoReal();
                        break;
                    case 5:
                        Tabuada.TelaTabuada();
                        break;
                    case 6:
                        MediaAluno.TelaMediaAluno();
                        break;
                    case 7:
                        Console.WriteLine("Você saiu do sistema!");
                        break;
                    default:
                        TelaMenu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                Console.Clear();

                TelaMenu();
            }
        }
    }
}
