using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrenciplesExample.SolidPrenciples.DIP
{
    // Dependency Inversion Principle(DIP)
    // Üst seviye (High-Level) sınıflar, alt seviye (Low-Level) sınıflara bağlı olmamalıdır, ilişki abstraction veya interface kullanarak sağlanmalıdır,
    // Abstraction(soyutlama) detaylara bağlı olmamalıdır, tam tersi detaylar abstraction(soyutlama)’lara bağlı olmalıdır.

    #region High Level Class
    public class MoneyTransfer
    {
        IAccountTransactions _accountTransactions;
        public MoneyTransfer(IAccountTransactions accountTransactions)
        {
            _accountTransactions = accountTransactions;
        }
        public void DoMoneyTranfer()
        {
            _accountTransactions.WithdrawFromAccount();
        }
    }
    #endregion

    #region Low Level Class and Inteface
    public interface IAccountTransactions
    {
        public void WithdrawFromAccount();
    }
    public class AccountTransactions : IAccountTransactions
    {
        public void WithdrawFromAccount()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
