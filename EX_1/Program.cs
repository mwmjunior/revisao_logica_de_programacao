using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que digite um número inteiro
        Console.Write("Digite um número inteiro: ");
        
        // Lê a entrada do usuário e tenta converter para um número inteiro
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            // Verifica se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite um número inteiro válido.");
        }
    }
}
