class Progam
{
    static void Main()
    {
        int i = 10;
        long l = 10;

        l = i; //pode armazenar
        i = l; //não pode armazenar

        i = (int)l;
        string s = (string)l; //não pode armazenar

        string s = l.ToString();

        Console.WriteLine(i);
    }
}
