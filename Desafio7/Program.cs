/* 7- Crie um indexador para uma classe Aluno para gerenciar uma coleção de nomes de alunos com no máximo  10 elementos.
 Para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado */

using Desafio7;

Aluno aluno = new Aluno();

//Atribuindo valor = get //[PosiçãoDoElemento]
aluno[1] = "Rafael";
aluno[2] = "Pedro";
aluno[5] = "Gustavo";
aluno[7] = "João";
aluno[-2] = "Wdson";
aluno[100] = "Mateus";

//Retornando valor
string valor1 = aluno[1];
string valor2 = aluno[2];
string valor3 = aluno[5];
string valor4 = aluno[7];
string valor5 = aluno[-2];
string valor6 = aluno[100];

//Exibindo valores
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);



