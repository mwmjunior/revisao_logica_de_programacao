// Programa que recebe 5 notas de um aluno e calcula a média aritmética.

Console.WriteLine(@$"
|--------------------------------------------------------------------------------------------------|
|                 Programa para calcular a média aritmética de 5 notas de um aluno                 |       
|--------------------------------------------------------------------------------------------------| 
");

//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//
 
float nota1, nota2, nota3, nota4, nota5, media;
string status;

Console.WriteLine($"Digite a primeira nota do aluno: ");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a segunda nota do aluno: ");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a terceira nota do aluno: ");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quarta nota do aluno: ");
nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quinta nota do aluno: ");
nota5 = float.Parse(Console.ReadLine());

//*************************************** PROCESSAMENTO DE DADOS ******************************************//

media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

if (media < 5)
{
    status = "Reprovado!";
}
else if (media >= 5 && media < 7)
{
    status = "Em recuperação.";
}
else
{
    status = "Aprovado!";
}

//*************************************** SAÍDA DE DADOS *************************************************//

Console.WriteLine(@$"

|----------------------------------------------|
|           VALIDAÇÃO DA MÉDIA DO ALUNO        |
|----------------------------------------------|
     MÉDIA: {media:F2}                                                                                                      
     STATUS: {status}
");
