namespace SolidPrenciplesExample.SolidPrenciples.ISP
{
    // Interface Segregation Principle (ISP)
    // Tüm metodları kapsayan tek bir interface kullanmak yerine herbiri ayrı metod gruplarına hizmet veren birden fazla interface tercih edilmelidir.
    public interface IMoneyTransfer
    {
        public decimal Amount { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string SourceAccountNumber { get; set; }
        public void DoMoneyTransfer();
    }
    public interface ICards
    {
        public string CardNumber { get; set; }
        public void GetCardActivities();
    }
    public interface IPayments
    {
        public string LicensePlate { get; set; }
        public void PayMotorVehicleTax();
    }
    public interface IAccounts
    {
        public decimal Balance { get; set; }
        public void GetAccountActivities();
    }
}
