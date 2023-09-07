namespace ClassLibrary2
{
    public interface IBank
    {
       long AccountNo { get; set; }
       string Name {get; set; }
        string Address { get; set; }
        long Balance { get; }
        long PhoneNumber { get; set; }
        void Deposit(int Amount);
        void WithDraw(int Amount);

    }

    public interface ISaving : IBank
    {
        long MinimumBalance { get; set; }
        long NoOfWithdrawl { get; set; }
        long WithdrawLimit { get; set; }
    }
}