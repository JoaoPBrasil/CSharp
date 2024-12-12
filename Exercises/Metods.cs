class Progam
{
    static void Main()
    {
        Run((x, y) => x * y);

        var test = (string name) => Console.WriteLine($"Ola {name}");

        test("John Wick");

        Func<decimal> test2 = () => 4.2m;

        Console.WriteLine(test2());

        Func<string, bool> checkName = name => name == "Joao";

        Console.WriteLine(checkName("Pedro"));
    }

    static void Run(Func<int, int, int> calc)
    {
        Console.WriteLine(calc(20,30));
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}

delegate int Calculate(int x, int y);

class FileLogger : ILogger
{
    private readonly string filePatch;

    public FileLogger(string filePatch)
    {
        this.filePatch = filePatch;
    }
    public void Log(string message)
    {
        File.AppendAllText(filePatch, $"{message}{Environment.NewLine}");
    }
}

class ConsoleLogger : ILogger
{
}

interface ILogger
{
    void Log(string message)
    {
        Console.WriteLine($"LOGGER: {message}");
    }
}

class BankAccount
{
    private string name;
    private readonly ILogger logger;

    public decimal Balance 
    { 
        get; private set;   
    }

    public BankAccount(string name, decimal balance, ILogger logger)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Nome Inválido.", nameof(name));
        }
        if (balance < 0)
        {
            throw new Exception("Saldo não pode ser negativo.");
        }
        this.name = name; //ou _name
        Balance = balance; //ou _balance
        this.logger = logger;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            logger.Log($"não é possível depositar {amount} na conta de {name}");
            return;
        }
        else
        {
            Balance += amount;
        }
        
    }
}
