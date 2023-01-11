namespace SolidPrenciplesExample.SolidPrenciples.OCP
{
    // Open Closed Principle (OSP)
    // Her class geliştirmeye açık olmalı fakat değişime kapalı olmalıdır.
    public abstract class MoneyTransfer
    {
        public decimal AccountBalance { get; set; }
        public abstract void DoMoneyTransfer(decimal amount, string sourceAccount, string destinationAccount);
    }

    public class BetweenMyAccounts
    {
        public override void DoMoneyTransfer(decimal amount, string sourceAccount, string destinationAccount)
        {
            throw new NotImplementedException();
        }
    }
    public class ToAnotherReceiverRemittanceorEFT
    {
        public override void DoMoneyTransfer(decimal amount, string sourceAccount, string destinationAccount)
        {
            throw new NotImplementedException();
        }
    }
}
