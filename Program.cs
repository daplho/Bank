// See https://aka.ms/new-console-template for more information

using Bank;

BankAccount regularAccount;
try
{
    regularAccount = new BankAccount("Lauren", 3621);
    Console.WriteLine(
        $"Account {regularAccount.Number} was created for {regularAccount.Owner} with ${regularAccount.Balance} initial balance.");

    regularAccount.MakeWithdrawal(500, DateTime.Now, "Rent payment");
    Console.WriteLine($"Account balance: ${regularAccount.Balance}");

    regularAccount.MakeDeposit(100, DateTime.Now, "Friend paid me back");
    Console.WriteLine($"Account balance: ${regularAccount.Balance}");

    regularAccount.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw");
}
catch(InvalidOperationException ioe)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(ioe.ToString());
}

// Test that the initial balances must be positive.
BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance.");
    Console.WriteLine(e.ToString());
    return;
}