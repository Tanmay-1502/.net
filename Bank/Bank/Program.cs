using ClassLibrary2;

ISaving Obj1 = new Hdfc();
Obj1.MinimumBalance = 100;
Obj1.WithdrawLimit = 1000;
Obj1.Deposit(50);
Obj1.Deposit(50);
Console.WriteLine("Balance: {0}", Obj1.Balance);