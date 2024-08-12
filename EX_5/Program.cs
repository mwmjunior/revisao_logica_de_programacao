using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine().ToLower(); // Converte código ignora se as letras que são maiúsculas ou minúsculas ao 
                                                     // realizar uma operação, como comparação de strings ou contagem de caracteres.

        // Dicionário para armazenar a contagem de cada letra
        Dictionary<char, int> contagemLetras = new Dictionary<char, int>();

        // Inicia o dicionário com as letras do alfabeto
        for (char letra = 'a'; letra <= 'z'; letra++)
        {
            contagemLetras[letra] = 0;
        }

        // Conta a frequência de cada letra no texto
        foreach (char c in texto)
        {
            if (contagemLetras.ContainsKey(c))
            {
                contagemLetras[c]++;
            }
        }

        // Exibi os resultados
        Console.WriteLine("\nFrequência das letras no texto:");
        foreach (var item in contagemLetras)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
