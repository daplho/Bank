namespace Bank;

public class LineOfCreditAccount : BankAccount
{
    public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) :
        base(name, initialBalance, -creditLimit) { }

    public override void PerformMonthEndTransactions()
    {
        if (Balance < 0)
        {
            // Negate the balance to get a positive interest charge:
            decimal interest = -Balance * 0.07m;
            MakeWithdrawal(interest, DateTime.Now, "Charge montly interest");
        }
    }

    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
        isOverdrawn
        ? new Transaction(-20, DateTime.Now, "apply overdraft fee")
        : default;

}