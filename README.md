# Exercícios C#

Este repositório contém uma série de exercícios em C# realizados para o curso "C# Essencial" do professor Macoratti.

## Exercício 1

Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e realize as seguintes operações:
- **Dados:** Maçã, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
  1. Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços `for` e `foreach`.
  2. Exiba os nomes da segunda e da penúltima fruta no console.
  3. Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas.
  4. Ordene a coleção de frutas na ordem ascendente.
  5. Exiba no console a coleção de nomes de frutas na ordem inversa.

## Exercício 2

Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para isso, siga estas etapas:
1. Solicite via teclado o número de valores do array (deve ser um número inteiro).
2. Declare e inicialize um array de inteiros com a quantidade de números inteiros informados.
3. Solicite ao usuário um valor de um número inteiro a procurar no array.
4. Exiba se o número informado existe no array de inteiros ou não.
5. Repita até que o texto ‘fim’ seja inserido via teclado.

## Exercício 3

Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo `float`, para 10 alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).

## Exercício 4

Crie um programa C# que usa uma `ArrayList` para armazenar uma lista de objetos pessoas.
1. Primeiro crie uma classe chamada `Pessoa.cs` com duas propriedades (nome e idade) e um método `Exibir()` para imprimir o nome e a idade.
2. A seguir crie uma `ArrayList` e solicite a informação dos nomes e idades de 3 pessoas via teclado armazenando as informações na `ArrayList`.
3. A seguir exiba no console a lista das pessoas com nome e idade.
4. Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas.
5. Remova o último elemento da coleção e exiba a lista completa.
   - Use os seguintes dados iniciais: Ana, 22 - Diná, 21 - Maria, 19
   - Ao incluir os objetos pessoa, use os dados: Jaime, 20 - Tânia, 18

## Exercício 5

Dada uma classe `Produto` contendo duas propriedades: `Nome` (string) e `Preco` (decimal). Crie uma lista de objetos do tipo `Produto` usando os seguintes dados:
- Clips, R$ 3,95
- Caneta, R$ 5,99
- Lápis, R$ 4,15
- Estojo, R$ 6,99
- Caderno, R$ 7,55

A seguir realize as seguintes operações na lista de objetos `Produto` criada:
1. Crie um método para exibir a relação de produtos, a soma total dos preços dos produtos, a média do preço dos produtos e a quantidade de produtos na lista.
2. Inclua na lista o seguinte produto: Mochila, R$ 22,44 e exiba novamente a lista de produtos.
3. Ordene a lista pelo nome do produto e exiba a lista ordenada.
4. Obtenha e exiba no console os produtos com preço inferior a R$ 5,00.
5. Localize na lista o produto com nome Estojo.

## Exercício 6

Crie um programa C# e defina um método chamado `ProcessaObjetos()` que possa receber um número variável de argumentos e que possa exibir os seus valores e também o tipo do objeto (use o método `GetType()` herdado de `Object`) no console.
- Passe os seguintes argumentos ao invocar o método: `ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null)`

## Exercício 7

Crie um indexador para uma classe `Aluno` para gerenciar uma coleção de nomes de alunos com no máximo 10 elementos.
- Para testar a implementação, atribua nomes e obtenha os valores atribuídos usando o indexador criado.

---

Desafio do Curso C# Essencial do professor Macoratti
