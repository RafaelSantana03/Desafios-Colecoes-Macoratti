using System;
using System.Collections;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirPessoa()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

class Program
{
    static void Main()
    {
        ArrayList pessoas = new ArrayList();

        // B) Solicitando dados via teclado
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nInforme o nome da pessoa {i + 1}: ");
            string nome = Console.ReadLine();

            Console.Write($"Informe a idade da pessoa {i + 1}: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            // Armazenando os dados no array
            pessoas.Add(new Pessoa(nome, idade));
        }

        // C) Exibindo os dados
        Console.WriteLine("\n## Lista de Pessoas");
        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.ExibirPessoa();
        }

        // D) Incluindo mais pessoas na lista
        pessoas.Add(new Pessoa("Jaime", 20));
        pessoas.Add(new Pessoa("Tania", 18));
        Console.WriteLine("\n## Lista Atualizada");
        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.ExibirPessoa();
        }

        // E) Removendo o último elemento da coleção
        pessoas.RemoveAt(pessoas.Count - 1);
        Console.WriteLine("\n## Lista Após Remoção do Último Elemento");
        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.ExibirPessoa();
        }
    }
}
