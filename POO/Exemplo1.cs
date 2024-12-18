using System;
using ConsoleApp1;

class Teste2
{
    static void Main()
    {
        House house1 = new House();
        house1.Address = "Rua xyz, 123";
        house1.Color = "Verde";

        House house2 = new House();
        house2.Address = "Rua aaa, 33";
        house2.Color = "Azul";

        BankAccount bankAccount = new BankAccount();
        bankAccount.PersonName = "Joao";
        bankAccount.Deposit(100);
        bankAccount.ShowDetails();
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
    public string PersonName;
    public decimal Balance;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{PersonName} possi saldo de {Balance:C2}");
    }

}
