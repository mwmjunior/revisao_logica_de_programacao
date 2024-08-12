using System; // Importa o namespace System para usar funcionalidades básicas, como entrada e saída no console.

class Program
{
    static void Main()
    {
        // Cria um vetor para armazenar 5 nomes
        string[] nomes = new string[5];

        // Solicita ao usuário que digite 5 nomes
        Console.WriteLine("Digite 5 nomes:");

        // Laço para capturar 5 nomes do usuário
        for (int i = 0; i < nomes.Length; i++)
        {
            // Solicita o nome do usuário e armazena no vetor
            Console.Write($"Nome {i + 1}: ");
            nomes[i] = Console.ReadLine(); // Lê o nome digitado e armazena na posição correspondente do vetor
        }

        // Ordena o vetor de nomes usando o método Bubble Sort
        BubbleSort(nomes);   // chama método BubbleSort, e o vetor nomes é passado para ele como um argumento.

        // Imprime os nomes ordenados
        Console.WriteLine("\nNomes em ordem alfabética:");
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]); // Exibe cada nome em ordem alfabética
        }
    }

    // Função que realiza a ordenação
    // Método para ordenar um vetor de strings usando Bubble Sort
    static void BubbleSort(string[] arr)
    {
        int n = arr.Length; // Armazena o tamanho do vetor
        // Laço para percorrer o vetor
        for (int i = 0; i < n - 1; i++)
        {
            // Laço para comparar e trocar elementos adjacentes
            for (int j = 0; j < n - i - 1; j++)
            {
                // Compara dois elementos adjacentes
                if (string.Compare(arr[j], arr[j + 1]) > 0)
                {
                    // Troca arr[j] e arr[j + 1] se estiverem na ordem errada
                    string temp = arr[j]; // Armazena arr[j] em uma variável temporária
                    arr[j] = arr[j + 1]; // Move arr[j + 1] para a posição arr[j]
                    arr[j + 1] = temp; // Move o valor armazenado em temp para arr[j + 1]
                }
            }
        }
    }
}
