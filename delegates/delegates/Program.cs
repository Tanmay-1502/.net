using System.Net.Security;
using System.Security.AccessControl;

namespace delegates
{
   public delegate bool MyDelegate(int Amount)
        internal class program
    {
        MyDelegate Hello=new MyDelegate(ObjS.Deposit);
        bool Status = Hello.Invoke(100);
        Console.WriteLine(ObjS.Balance);
    }
}