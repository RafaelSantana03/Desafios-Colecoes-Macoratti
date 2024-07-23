using Desafio5;
using System.ComponentModel;


public class Program
{
    public static void Main(string[] args)
    {
        var lista = new List<Produto>()
        {
         new Produto {Nome = "Clips", Preco = 3.95M},
         new Produto {Nome = "Caneta", Preco = 5.99M},
         new Produto {Nome = "Lapis", Preco = 4.15M},
         new Produto {Nome = "Estojo", Preco = 6.99M},
         new Produto {Nome = "Caderno", Preco = 7.55M}
        };
        ExibirRelacaoProdutos(lista);


        // 2- Inclua na lista o seguinte produto :  Mochila, R$ 22,44  e exiba novamente a lista de produtos
        lista.Add(new Produto { Nome = "Mochila", Preco = 22.44M });
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nLista Atuatlizada");
        Console.ResetColor();
        ExibirRelacaoProdutos(lista);

        // 3- Ordene a lista pelo nome do produto e exiba a lista ordenada
        lista = lista.OrderBy(p => p.Nome).ToList();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nLista Ordenada");
        Console.ResetColor();
        ExibirRelacaoProdutos(lista);


        // 4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00
        var produtosAbaixoDeCinco = lista.Where(p => p.Preco < 5.00M).ToList();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nValores Abaixo de 5: ");
        Console.ResetColor();
        ExibirRelacaoProdutos(produtosAbaixoDeCinco);
        //5- Localize na lista o produto com nome Estojo
        var listaEstojo = lista.FirstOrDefault(p => p.Nome == "Estojo");
        if(listaEstojo != null)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nProduto encontrado com sucesso");
            Console.ResetColor();
            Console.WriteLine($"Nome: {listaEstojo.Nome}, Preço: {listaEstojo.Preco.ToString("C")}");
        }
        else
        {
            Console.WriteLine("Não existe esse item na lista");
        }
    }

    //1- Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do 
    //preço dos produtos e a quantidade de produtos na lista
    public static void ExibirRelacaoProdutos(List<Produto> produto)
    {
        Console.WriteLine("Relação de Produtos: ");
        foreach (var item in produto)
        {
            Console.WriteLine($"Nome: {item.Nome}, Preço: { item.Preco}");
        }
        //Soma Total dos produtos
        decimal somaTotal =0;
        foreach (var item in produto)
        {
            somaTotal += item.Preco;
        }

        //Média dos preços dos produtos
        decimal mediaPreco = produto.Count > 0 ? somaTotal / produto.Count : 0;

        //Quantidade De Produtos
        int quantidadeProdutos = produto.Count;

        Console.WriteLine($"\nSoma total dos preços dos produtos: {somaTotal.ToString("C")}");
        Console.WriteLine($"Média dos Produtos: {mediaPreco.ToString("C")}");
        Console.WriteLine($"Quantidade de Produtos: {quantidadeProdutos}");
    }


}