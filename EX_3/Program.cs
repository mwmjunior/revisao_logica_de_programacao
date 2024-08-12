using System;

class Program
{
    static void Main()
    {
        // Defini o vetor de 10 elementos
        int[] numeros = new int[10];
        
        // Solicita a entrada do usuário para preencher o vetor
        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Inicia a variável para armazenar a soma dos números pares
        int somaPares = 0;

        // Percorre o vetor para somar os números pares
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
            }
        }

        // Exibi o resultado
        Console.WriteLine($"A soma dos números pares no vetor é: {somaPares}");
    }
}
