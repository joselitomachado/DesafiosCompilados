namespace Desafios.Models
{
    public class MediaAluno
    {
        public static void TelaMediaAluno()
        {
            Console.WriteLine("========================[ Desafio 6]========================\n");

            string nomeAluno, nomeMateria;
            decimal notaUnidade1, notaUnidade2, notaUnidade3, notaUnidade4, mediaGeral;

            try
            {
                Console.WriteLine("Digite o nome do aluno: ");
                nomeAluno = Console.ReadLine();

                Console.WriteLine("\nDigite o nome da matéria: ");
                nomeMateria = Console.ReadLine();

                Console.WriteLine($"\nDigite a nota da 1ª unidade: ");
                notaUnidade1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"\nDigite a nota da 2ª unidade: ");
                notaUnidade2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"\nDigite a nota da 3ª unidade: ");
                notaUnidade3 = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"\nDigite a nota da 4ª unidade: ");
                notaUnidade4 = decimal.Parse(Console.ReadLine());

                mediaGeral = (notaUnidade1 + notaUnidade2 + notaUnidade3 + notaUnidade4) / 4;

                if (mediaGeral >= 7.00m)
                {
                    Console.WriteLine($"Parabéns {nomeAluno}, você foi aprovado com a média: {mediaGeral} na matéria {nomeMateria}");
                }
                else
                {
                    Console.WriteLine($"{nomeAluno} você foi reprovado com a média: {mediaGeral} na matéria {nomeMateria}");
                }

                Menu.TelaMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                Console.Clear();

                TelaMediaAluno();
            }
        }
    }
}