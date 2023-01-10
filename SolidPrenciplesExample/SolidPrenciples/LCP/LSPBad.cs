namespace SolidPrenciplesExample.SolidPrenciples.LCP
{
    // Liskov Substitution Principle (LSP)
    // Kalıtım alınan sınıfların tüm özellikleri kullanılmak zorundadır
    public abstract class Card
    {
        public string? CreditCardNumber { get; set; }
        public string? AccountNumber { get; set; }

        public virtual void PayDebt()
        {
            throw new NotImplementedException();
        }

        public virtual void DoMoneyTransfer()
        {
            throw new NotImplementedException();
        }

        public virtual void GetActivities()
        {
            throw new NotImplementedException();
        }
    }

    public class DebitCard: Card
    {
        public override void PayDebt()
        {
            throw new NotImplementedException();
        }

        public override void DoMoneyTransfer()
        {
            throw new NotImplementedException();
        }

        public override void GetActivities()
        {
            throw new NotImplementedException();
        }
    }

    public class CreditCard: Card
    {
        public override void PayDebt()
        {
            throw new NotImplementedException();
        }

        public override void DoMoneyTransfer()
        {
            throw new NotImplementedException();
        }

        public override void GetActivities()
        {
            throw new NotImplementedException();
        }
    }
}

