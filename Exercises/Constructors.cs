class Progam
{
    static void Main()
    {
        BankAccount account1 = new BankAccount();
        account1.name = "Joao";
        account1.balance = 100;

        BankAccount account2 = new BankAccount();
    }
}

class BankAccount
{
    private string _name;
    private decimal _balance;

    public BankAccount(string name, decimal balance)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Nome Inválido.");
        }
        if (balance < 0)
        {
            throw new Exception("Saldo não pode ser negativo.");
        }
        _name = name; //ou this.name
        _balance = balance; //ou this.balance
    }
}
