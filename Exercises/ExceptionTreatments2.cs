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
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Erro IdexOutOfRangeException");
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Error: {exception.StackTrace}");
        }
        catch
        {
            Console.WriteLine($"Error");
        }

    }
}
