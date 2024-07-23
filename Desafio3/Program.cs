

//Declarando um array bidimensional de 2 linhas e 5 colunas
float[,] notas = new float[2, 5];

//declarando e atribuindo valores ao array
for (int i = 0; i < notas.GetLength(0); i++) //GetLenght(0) = Posição de linhas
{
    //GetLenght(1) = Posição de colunas
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        Console.WriteLine($"Informe a nota do Aluno {j + 1} do grupo {i + 1} ");
        notas[i, j] = float.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

//Calculando e exibidno a soma da média aritmética 
for (int i = 0; i < notas.GetLength(0); i++)
{
    float soma = 0;
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        soma += notas[i, j];
    }
    float media = soma / notas.GetLength(1);
    Console.WriteLine($"Média Aritmética do grupo {i + 1} é igual {media}");
}
