using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Hdfc : ISaving
    {
        private long MinBal;
        private long NumWithdraw;
        private long WidL;
        private long ANo;
        private string name;
        private string add;
        private long Bal;
        private long PNo;


        public long MinimumBalance { get { return MinBal; } set { MinBal = value; } }
        public long NoOfWithdrawl { get { return NumWithdraw; } set { NumWithdraw = value; } }
        public long WithdrawLimit { get { return WidL; } set { WidL = value; } }
        public long AccountNo { get { return ANo; } set { ANo = value; } }
        public string Name { get { return name; }  set { name = value; } }
        public string Address { get { return add; } set { add = value; } }

        public long Balance { get { return Bal; } }

        public long PhoneNumber { get { return PNo; } set { PNo = value; } }

        public void Deposit(int Amount)
        {
            if(Amount > 0) { 
            Bal += Amount;
            }
        }

        public void WithDraw(int Amount)
        {
            Bal-= Amount;
            NoOfWithdrawl++;
        }
    }
}
