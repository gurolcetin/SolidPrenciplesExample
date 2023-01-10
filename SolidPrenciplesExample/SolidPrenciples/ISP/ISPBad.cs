namespace SolidPrenciplesExample.SolidPrenciples.ISP
{    
    // Interface Segregation Principle (ISP)
    // Tüm metodları kapsayan tek bir interface kullanmak yerine herbiri ayrı metod gruplarına hizmet veren birden fazla interface tercih edilmelidir.
    public interface IBanka
    {
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string SourceAccountNumber { get; set; }
        public string CardNumber { get; set; }
        public string LicensePlate { get; set; }

        public void DoMoneyTransfer();
        public void PayMotorVehicleTax();
        public void GetAccountActivities();
        public void GetCardActivities();
    }
}
