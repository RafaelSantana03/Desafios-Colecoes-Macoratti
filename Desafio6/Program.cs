using System;

public class Teste
{
    // Esta classe é apenas um exemplo para ser usada como argumento no método ProcessaObjetos
}

public class Program
{
    public static void Main()
    {
        ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);
    }
    public static void ProcessaObjetos(params object[] objetos)
    {
        foreach (var obj in objetos)
        {
            if (obj != null)
            {
                Console.WriteLine($"Valor: {obj}, Tipo: {obj.GetType()}");
            }
            else
            {
                Console.WriteLine("Valor: null, Tipo: null");
            }
        }
    }

    
}

