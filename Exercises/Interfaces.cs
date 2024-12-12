class Progam
{
    static void Main()
    {
        ILogger logger = new FileLogger("mylog.txt"); 
        BankAccount account1 = new BankAccount("Joao", 100, logger);
        BankAccount account2 = new BankAccount("Pedro", 100, logger);
        //account1.name = "Joao";
        //account1.balance = 100;

        account1.Deposit(-100);

        account2.Deposit(150);


        Console.WriteLine(account2.Balance);
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
