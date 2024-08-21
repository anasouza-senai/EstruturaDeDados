internal class Program
{
    private static void Main(string[] args)
    {
        // TRABALHADO COM LISTA ( LIST )

        /* Criando uma lista */
        List<string> frutas = new List<string>();

        /* Adicionar itens na Lista*/
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        /* Imprimir os Itens da Lista */
        Console.WriteLine("Minha lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine();

        /* Imprimir elemento na posição específica */
        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        /* Inserir um elemento no indice específico */
        frutas.Insert(1, "Marcujá");

        /* Imprimindo a Lista novamente */
        Console.WriteLine("Minha lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* Alterar um elemento no Índice específico*/
        frutas[4] = "Pêra";
        Console.WriteLine();
        Console.WriteLine("Minha lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* Remover elementos da lista no indice especifico*/
        frutas.RemoveAt(3);

        frutas.Remove("Morango");

        Console.WriteLine();
        Console.WriteLine("Minha lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }



        frutas.ForEach(Console.WriteLine);

        Console.WriteLine();

        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        /* Apagar todos os elementos da listas */
        frutas.Clear();
    }
}