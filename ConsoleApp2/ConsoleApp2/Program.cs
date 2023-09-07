// See https://aka.ms/new-console-template for more information
using ClassLibrary2;
ISaving Obj1 = new Hdfc();
Obj1.MinimumBalance = 100;
Obj1.WithdrawLimit = 1000;
Obj1.Deposit(50);
Console.WriteLine("Balance", Obj1.Balance);
