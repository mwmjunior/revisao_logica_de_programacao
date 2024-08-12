using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para ver sua tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        // Chama a função para exibir a tabuada do número
        ExibirTabuada(numero);
    }

    // Função que exibe a tabuada de um número até 10
    static void ExibirTabuada(int numero)
    {
        Console.WriteLine($"Tabuada do {numero}:");
        
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
