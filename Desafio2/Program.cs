using System;

class Program
{
    static void Main()
    {
        // a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
        Console.Clear();
        Console.Write("Informe o tamanho do array: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        // b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
        int[] valores = new int[valor]; // Declarando o array

        for (int i = 0; i < valor; i++) // Incrementando valores no array com um laço for
        {
            valores[i] = i;
        }

        // Exibindo os valores do array
        Console.WriteLine("Valores no array:");
        foreach (int item in valores)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        // c-) Solicite ao usuário um valor de um número inteiro a procurar no array
        while (true)
        {
            Console.Write("\nInforme um valor de um número que tenha no array (ou digite 'fim' para sair): ");
            string input = Console.ReadLine();

            // Verifique se o usuário deseja sair
            if (input.Equals("fim", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            // Verifique se a entrada é um número válido
            if (int.TryParse(input, out int numero))
            {
                // d-) Exiba se o número informado existe no array de inteiros ou não
                int indice = Array.IndexOf(valores, numero);
                if (indice >= 0)
                {
                    Console.WriteLine($"Número: {numero} foi encontrado com índice: {indice}");
                }
                else
                {
                    Console.WriteLine("Esse número não existe no array");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido ou 'fim' para sair.");
            }
        }
    }
}
