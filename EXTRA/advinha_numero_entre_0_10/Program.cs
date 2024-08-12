using System;

class Program
{
    static void Main()
    {
        // Gerar um número aleatório entre 1 e 10
        Random random = new Random();
        int numeroAleatorio = random.Next(0, 10);

        int palpite;
        int tentativas = 0;

        Console.WriteLine("Tente adivinhar o número que estou pensando (entre 1 e 10):");

        // Loop do-while para continuar pedindo um palpite até que o usuário acerte
        do
        {
            tentativas++;
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine());

            if (palpite < 1 || palpite > 10)
            {
                Console.WriteLine("Por favor, insira um número entre 1 e 10.");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("Muito alto! Tente novamente.");
            }
            else if (palpite < numeroAleatorio)
            {
                Console.WriteLine("Muito baixo! Tente novamente.");
            }

        } while (palpite != numeroAleatorio);

        Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
    }
}