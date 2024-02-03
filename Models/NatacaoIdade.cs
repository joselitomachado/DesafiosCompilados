namespace Desafios.Models
{
    public class NatacaoIdade
    {
        public static void TelaNatacaoIdade()
        {
            Console.WriteLine("========================[ Desafio 2]========================\n");

            int idade;

            try
            {
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Sua categoria é Infantil A");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("Sua categoria é Infantil B");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("Sua categoria é Juvenil A");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Sua categoria é Juvenil B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Sua categoria é Adulto");
                }
                else
                {
                    Console.WriteLine("Você não pode participar do campeonato, pois, não tem idade suficiente!");
                }

                Menu.TelaMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                Console.Clear();

                TelaNatacaoIdade();
            }
        }
    }
}
