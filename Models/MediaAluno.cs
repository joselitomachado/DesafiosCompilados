namespace Desafios.Models
{
    public class MediaAluno
    {
        public static void TelaMediaAluno()
        {
            Console.WriteLine("========================[ Desafio 6]========================\n");

            string nomeAluno, nomeMateria;
            double notaUnidade1, notaUnidade2, notaUnidade3, notaUnidade4, mediaGeral;

            try
            {
                Console.WriteLine("Digite o nome do aluno: ");
                nomeAluno = Console.ReadLine();

                Console.WriteLine("\nDigite o nome da matéria: ");
                nomeMateria = Console.ReadLine();

                Console.WriteLine($"\nDigite a nota da 1ª unidade: ");
                notaUnidade1 = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nDigite a nota da 2ª unidade: ");
                notaUnidade2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nDigite a nota da 3ª unidade: ");
                notaUnidade3 = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nDigite a nota da 4ª unidade: ");
                notaUnidade4 = double.Parse(Console.ReadLine());

                mediaGeral = (notaUnidade1 + notaUnidade2 + notaUnidade3 + notaUnidade4) / 4;

                if (mediaGeral >= 6)
                {
                    Console.WriteLine($"Parabéns {nomeAluno}, você foi aprovado com a média ( {mediaGeral} ) na matéria de {nomeMateria}");
                }
                else
                {
                    Console.WriteLine($"{nomeAluno} você foi reprovado com a média ( {mediaGeral} ) na matéria de {nomeMateria}");
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