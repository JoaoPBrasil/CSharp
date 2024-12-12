class Progam
{
    static void Main()
    {
        string name = "Joao";

        Console.WriteLine(name.Length);
        Console.WriteLine(name.StartsWith('J'));
        Console.WriteLine(name.EndsWith('o'));
        Console.WriteLine(name.StartsWith("Jo"));
        Console.WriteLine(name.Contains("a"));
        Console.WriteLine(name.IndexOf("oa"));

        Console.WriteLine(string.IsNullOrEmpty(name));
        Console.WriteLine(string.IsNullOrWhiteSpace(name));

    }
}
