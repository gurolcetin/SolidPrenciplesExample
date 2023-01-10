namespace SolidPrenciplesExample.SolidPrenciples.OCP
{
    // Open Closed Principle (OSP)
    // Her class geliştirmeye açık olmalı fakat değişime kapalı olmalıdır.
    public class MoeyTransferBad
    {
        public decimal AccountBalance { get; set; }
        public string? TransferType { get; set; }
        public void DoMoneyTransfer(decimal amount, string sourceAccount, string destinationAccount)
        {
            if(TransferType == "BetweenMyAccounts")
            {
                BetweenMyAccounts(amount, sourceAccount, destinationAccount);
            }            
            else if(TransferType == "ToAnotherReceiverRemittanceorEFT")
            {
                ToAnotherReceiverRemittanceorEFT(amount, sourceAccount, destinationAccount);
            }
        }
        public void BetweenMyAccounts(decimal amount, string sourceAccount, string destinationAccount)
        {
            throw new NotImplementedException();
        }

        public void ToAnotherReceiverRemittanceorEFT(decimal amount, string sourceAccount, string destinationAccount)
        {
            throw new NotImplementedException();
        }
    }
}
