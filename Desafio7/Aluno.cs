/* 7- Crie um indexador para uma classe Aluno para gerenciar uma coleção de nomes de alunos com no máximo 10 elementos.
 Para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado */

namespace Desafio7
{
    public class Aluno
    {
        //Definir o limite do array
        string[] valor = new string[10];
        
        //Indexador
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < valor.Length)
                {
                    //Atribui valor
                    return valor[i];
                }
                return "Erro";
            }

            set
            {
                if(i >= 0 && i < valor.Length)
                {
                    //Retorna valor
                    valor[i] = value;
                }
            }
            
        }

    }
}
