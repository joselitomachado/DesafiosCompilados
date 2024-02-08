namespace Desafios.Models
{
    public class Tabuada
    {
        public static void TelaTabuada()
        {
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

                Menu.TelaMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                Console.Clear();

                TelaTabuada();
            }
        }
    }
}