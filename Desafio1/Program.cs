Console.Clear();
// 1- Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize 
//as seguintes operações : Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
string[] frutas = new string[] { "Maca ", "Banana ", "Laranja ", "Manga ", "Pera ", "Abacate ", "Mamao ", "Pessego ", "Amora " };

//Exibindo nome das frutas e informando a quantidade de Frutas
int count = 0;
foreach (var item in frutas)
{
    Console.Write($"{item} ");
    count++;
}
Console.WriteLine($"\n\nQuantidade de frutas: {count}");
Console.WriteLine("\n--------------------------------------------------------------------------");

//Exibindo a segunda e a penultima Fruta
Console.WriteLine("Exibindo a segunda e a penultima fruta:");
Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[7]);
Console.WriteLine("\n--------------------------------------------------------------------------");

// Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
Console.WriteLine("Altrando a terceira e penultima fruta: ");
frutas[2] = "Kiwi";
frutas[8] = "Caqui";
foreach (var item in frutas)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\n--------------------------------------------------------------------------");
//Ordene a coleção de frutas na ordem ascendente
Console.Write("Array Frutas ordenado de forma ascendente:\n");
Array.Sort(frutas);
foreach (var item in frutas)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\n--------------------------------------------------------------------------");
//Exiba no console a coleção de nomes de frutas na ordem inversa
Console.Write("Array Frutas ordenado de forma inversa:\n");
Array.Reverse(frutas);
foreach (var item in frutas)
{
    Console.Write($"{item} ");
}