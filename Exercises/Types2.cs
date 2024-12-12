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
    public string name;
    public decimal balance;
}
