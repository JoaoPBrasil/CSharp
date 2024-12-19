using System;

class Teste2
{
    static void Main()
    {
        BankAccount bankAccount = new BankAccount("Joao");
        bankAccount.Deposit(100);
        bankAccount.ShowDetails();
        bankAccount.Withdrawn(50);

        Console.WriteLine(bankAccount.Balance);
        
    }
}

public class House
{
    public string Address;
    public string Color;

    public void TurnlightsOn()
    {
        Console.WriteLine("Luzes ligadas.");
    }

    public void TurnLightsOff()
    {
        Console.WriteLine("Luzes desligadas.");
    }
}

public class BankAccount
{
    private string personName;
    private decimal balance;

    public decimal Balance => balance;

    public BankAccount(string personName)
    {
        this.personName = personName;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdrawn(decimal amount)
    {
        if (amount > balance)
        {
            System.Console.WriteLine("Saldo insuficiente");

            return;
        }

        balance -= amount;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{personName} possi saldo de {balance:C2}");
    }

}
