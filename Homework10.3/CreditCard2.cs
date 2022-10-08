using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._3
{
    public class CreditCard2
    {
        public CreditCard2(int sum)
        {
            _sum = sum;
        }
        public event AccountAction account;
        public void RegisterAccountAction(AccountAction account)
        { this.account = account; }
        private int _sum { get; set; }

        public void Put(int sum)
        {
            _sum = +sum;
            if (account != null)
                account($"На счёт пришло {sum}");
        }

        public void Get(int sum)
        {
            _sum = -sum;
            if (account != null)
                account($"Со счёта снято {sum}");
        }
    }
}
