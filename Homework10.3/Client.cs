using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._3
{
//    Создать класс Client.В классе создать метод, который будет использован для передачи в экземпляр делегат/ событие.
//В методе main создать экземпляр класса CreditCard, создать экземпляр класса Client.Client должен подписаться 
//    на делегат/событие AccountAction экземпляра класса CreditCard.Вызвать методы Put, Get,
//    проанализировать результаты, сделать выводы. Добавить в делегат/событие AccountAction анонимный
//    метод, лямбда-выражение.Вызвать методы Put, Get, проанализировать результаты, сделать выводы.
    public class Client
    {
        public void ClientAccount(string mes)
        { 
        Console.WriteLine(mes);
        }
    }
}
