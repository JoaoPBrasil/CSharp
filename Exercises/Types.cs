class Progam
{
    static void Main()
    {
        int i = 10;
        int i2 = i;
        i2 = 20;

        Test t = new Test();
        t.X = 10;
        
        Test t2 = t;
        t2 = new Test();
        t2.X = 20;

        Console.WriteLine(t.X);
    }

    class Test
    {
        public int X;
        
    }
}
