using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._3
{
    //Создать класс CreditCard.В классе создать два метода Put - положить деньги на карту,
    //    Get - снять деньги с карты.В классе создать элемент AccountAction. Класс реализовать двумя способами: 
    //    когда AccountAction экземпляр делегата; когда AccountAction событие.

    public delegate void AccountAction(string mes);
    public class CreditCard
    {
        public CreditCard(int sum)
        {
            _sum = sum;
        }
       AccountAction accountAction;
        public void RegisterAccountAction(AccountAction accountAction)
        { this.accountAction = accountAction; }
        private int _sum { get; set; }

        public void Put(int sum)
        {
            _sum = +sum;
            if (accountAction != null)
                accountAction($"На счёт пришло {sum}");
        }

        public void Get(int sum)
        {
            _sum = -sum;
            if (accountAction != null)
                accountAction($"Со счёта снято {sum}");
        }
    }
}
