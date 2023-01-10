namespace SolidPrenciplesExample.SolidPrenciples.LCPGood
{
    // Liskov Substitution Principle (LSP)
    // Kalıtım alınan sınıfların tüm özellikleri kullanılmak zorundadır
    public abstract class Card
    {
        public virtual void GetActivities()
        {
            throw new NotImplementedException();
        }
    }
    public interface IBankomatCard
    {
        public void DoMoneyTransfer();
    }
    public abstract class BankomatCard : Card, IBankomatCard
    {
        public string? AccountNumber { get; set; }

        public void DoMoneyTransfer()
        {
            throw new NotImplementedException();
        }

        public override void GetActivities()
        {
            throw new NotImplementedException();
        }
    }
    public interface ICreditCard
    {
        public void PayDebt();
    }
    public abstract class CreditCard : Card, ICreditCard
    {
        public string? CreditCardNumber { get; set; }
        public void PayDebt()
        {
            throw new NotImplementedException();
        }

        public override void GetActivities()
        {
            throw new NotImplementedException();
        }
    }
}

