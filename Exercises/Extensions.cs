class Progam
{
    static void Main()
    {
        "Testando".WriteLine(ConsoleColor.Yellow);
    }
}

static class Extensions
{
    public static void WriteLine(this string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}

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
