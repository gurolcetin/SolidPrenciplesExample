namespace SolidPrenciplesExample.SolidPrenciples.SRP
{
    // Single Responsibility Prensible: 
    // Method, sınıf vb. yapıların tek bir görev ve sorumluluğu olmalıdır.
    public class BankTransactions
    {
        #region Properties
        public decimal AccountBalance { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public string? SourceAccount { get; set; }
        public string? DestinationAccount { get; set; }
        public string? LicensePlate { get; set; }
        public decimal TaxAmount { get; set; }
        #endregion

        #region Money Transfer Transaction

        public void DoMoneyTransfer()
        {
            CalculateTotalMoneyTransferAmount();
            Console.WriteLine(string.Format("Money Transfer Succeed. Total Amount: {0} FeeAmount: {1}, Amount: {2}, Source Account: {3}, Destination Account: {4}", TotalAmount, FeeAmount, Amount, SourceAccount, DestinationAccount));
        }

        public void CalculateTotalMoneyTransferAmount()
        {
            TotalAmount = FeeAmount + Amount;
        }

        #endregion

        #region Payments Transaction

        public void PayMotorVehicleTax()
        {
            Console.WriteLine(string.Format("Pay Motor Vehicle Tax Succeed. Tax Amount: {0} License Plate: {1}", TaxAmount, LicensePlate));
        }
        #endregion
    }
}
