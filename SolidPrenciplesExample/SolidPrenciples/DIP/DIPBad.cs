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


    // High Level Class
    public class MoneyTransferBad
    {
        public void DoMoneyTranfer()
        {
            AccountTransactionsBad accountTransactionsBad = new();
            accountTransactionsBad.WithdrawFromAccount();
        }
    }

    // Low Level Class
    public class AccountTransactionsBad
    {
        public void WithdrawFromAccount()
        {
            throw new NotImplementedException();
        }
    }
}
