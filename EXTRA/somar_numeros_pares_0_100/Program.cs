// // Programa que calcula e exibe os números pares de 0 a 100 (FOR)

// Console.WriteLine(@$"
// |-----------------------------------------------------|
// |            Números pares de 0 a 100                 |       
// |-----------------------------------------------------|
// ");

// // Loop de 0 a 100 para encontrar números pares
// for (int i = 0; i <= 100; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// Console.WriteLine(@$"
// |-----------------------------------------------------|
// |                   Fim da listagem                   |
// |-----------------------------------------------------|
// ");


// Programa que calcula e exibe os números pares de 0 a 100 (WHILE)

Console.WriteLine(@$"
|-----------------------------------------------------|
|            Números pares de 0 a 100                 |       
|-----------------------------------------------------|
");

int i = 0;
int soma= 0;

// Loop while de 0 a 100 para encontrar números pares
while (i <= 100)
{
    if (i % 2 == 0)
    {
        soma += i;
        Console.WriteLine(i);
    }
    i++;
}

Console.WriteLine($"{soma}");
