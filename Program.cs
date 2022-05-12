// See https://aka.ms/new-console-template for more information

using Bank;

var giftCard = new GiftCardAccount("gift card", 100, 50);
giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();

// can make additional deposits:
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
Console.WriteLine(giftCard.GetAccountHistory());

var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(750, DateTime.Now, "save some money");
savings.MakeDeposit(1250, DateTime.Now, "make some more savings");
savings.MakeWithdrawal(250, DateTime.Now, "needed to pay monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());

var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "take out montly advance");
lineOfCredit.MakeDeposit(50m, DateTime.Now, "pay back a small amount");
lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "emergency funds for repairs");
lineOfCredit.MakeDeposit(150m, DateTime.Now, "partial restoration on repairs");
lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "another monthly advance");
lineOfCredit.PerformMonthEndTransactions();
Console.WriteLine(lineOfCredit.GetAccountHistory());