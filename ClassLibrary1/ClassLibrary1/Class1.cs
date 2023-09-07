

namespace ClassLibrary1
{
    public enum TypeOfCall { MM, ML, MSTD, MISD };
    public abstract class AirtelCustomer
    {
       
        protected string Name;
        protected long phNo;
        protected long Bal;
        protected int CustID;
        protected string Add;

     
        protected string CustomerName { get { return Name; } set { Name = value; } }

        protected long PhoneNo { get { return phNo; } }

        protected long Balance { get { return Bal; } }

        protected int CustomerID { get { return CustID; } }

        protected string Address { get { return Add; } set { Add = value; } }




        public abstract void RecordCall(long Duration, TypeOfCall TOC);
     


    }

    public class PrePaid : AirtelCustomer
    {
        protected long Val;

 
        protected long Validity { get { return Val; } set { Val = value; } }

        
        public void Recharge(long Amount)
        {
        }

        public override void RecordCall(long Duration, TypeOfCall TOC)
        {
            switch (TOC)
            {
                case TypeOfCall.MM:
                    base.Bal -=(Duration); break;
                case TypeOfCall.ML:
                    base.Bal -= (Duration*2); break;
                case TypeOfCall.MISD:
                    base.Bal -= (Duration*3); break;
                case TypeOfCall.MSTD:
                    base.Bal -= (Duration * 4); break;

            }
       
        }
    }

    public class PostPaid : AirtelCustomer
    {
       
        protected long CreditLim;

        protected long CreditLimit { get { return CreditLim; } set { CreditLim = value; } }

        public void PayBill(long Amount) { }

        public override void RecordCall(long Duration, TypeOfCall TOC)
        {
            throw new NotImplementedException();
        }
    }
}








