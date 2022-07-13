using BankyStuffLibrary;

var account = new BankAccount("Kendra", 1000);
Console.WriteLine($"Account: {account.Number} was created for {account.Owner} with {account.Balance}.");

account.MakeWhitdrawal(120, DateTime.Now, "Hammock");
Console.WriteLine(account.Balance);

account.MakeWhitdrawal(50, DateTime.Now, "Xbox game");
Console.WriteLine(account.Balance);

Console.WriteLine(account.getAccountHistory());


// Test that the initial balances must be positive
//try
//{
//    account.MakeDeposit(300, DateTime.Now, "stealing");
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught, creating account with negative balance");
//    Console.WriteLine(e.ToString());
//}


