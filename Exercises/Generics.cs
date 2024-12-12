class Progam
{
    static void Main()
    {
        var logger = new FileLogger("mylog.txt"); 
        var account1 = new BankAccount("Joao", 100, logger);
        var account2 = new BankAccount("Pedro", 300, logger);

        var accounts = new List<BankAccount>
        {
            account1,
            account2
        };

        var store = new DataStore<string>();
        store.Value = "Joao";
        Console.WriteLine(store.Value.Length);
    }
}

class DataStore<T>
{
    public T Value {get; set; }
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
