class Progam
{
    static void Main()
    {
        int[] numbers = { 1 };
        string s = null;

        try
        {
            Console.WriteLine(s.Length);
        }
        catch (System.NullReferenceException exception)
        {
            Console.WriteLine($"Error de referência nula. {exception.Message}");
            Console.WriteLine($"Error de referência nula. {exception.StackTrace}");
        }

        try
        {
            Console.WriteLine(numbers[1]);
        }
        catch (System.NullReferenceException exception)
        {
            Console.WriteLine($"Error de referência nula. {exception.StackTrace}");
        }
        catch (System.IndexOutOfRangeException exception)
        {
            Console.WriteLine("Erro");
        }
    }
}
