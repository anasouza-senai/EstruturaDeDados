internal class Program
{
    private static void Main(string[] args)
    {
        // TRABALHANDO COM LISTA ( LIST )

        /* Criando uma lista */
        List<string> frutas = new List<string>();

        /* Adicionar itens na Lista*/
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        /* Imprimir os Itens da Lista
        /* Impressao da Lista em um única linha */
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); // Pula linha em Branco

        /* Imprimir elemento no indice específico */
        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        /* Inserir um elemento no indice específico */
        frutas.Insert(1, "Maracuja");

        /* Imprimindo a Lista novamente */
        Console.WriteLine(); // Pula linha em Branco

        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* Alterar um elemento no índice específico */
        frutas[4] = "Pêra";
        /* Imprimindo a Lista novamente */
        Console.WriteLine(); // Pula linha em Branco
        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* Remover elementos da lista no indice específico */
        frutas.RemoveAt(3);

        /* Remover elementos pelo valor do conteúdo */
        frutas.Remove("Morango");

        /* Imprimindo a Lista novamente */
        Console.WriteLine(); // Pula linha em Branco
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);

        /* Apagar todos os elementos da lista */
        frutas.Clear();

        // TRABALHANDO COM DICIONARIO (DICTIONARY)
        /* Criando um Dicionario de Dados */
        Dictionary<int, string> carros = new Dictionary<int, string>();
        /* Adicionar Dados a um Dicionário */
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        Console.WriteLine(); // Pula linha em Branco
        Console.WriteLine("============================");
        Console.WriteLine(); // Pula linha em Branco

        Console.WriteLine("Meu Dicionario de Carros:");
        /* Imprimir um Dicionario de Dados */
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }
    }
}