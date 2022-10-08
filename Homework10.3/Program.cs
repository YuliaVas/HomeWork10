namespace Homework10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard(50);
            Client client = new Client();
            creditCard.RegisterAccountAction(client.ClientAccount);
            creditCard.Put(50);
            creditCard.Get(40);
            creditCard.RegisterAccountAction(delegate(string mess) { Console.WriteLine($"аноним{mess}"); });
            creditCard.Get(50);
            creditCard.RegisterAccountAction((string mess) => Console.WriteLine($"лямбда {mess}"));
            creditCard.Put(10);

            CreditCard2 creditCard2 = new CreditCard2(50);
            creditCard2.account += client.ClientAccount;
            creditCard2.Put(40);
            creditCard2.Get(10);
            creditCard2.account += delegate(string mess) { Console.WriteLine($"аноним{mess}"); };
            creditCard2.Get(50);
            creditCard2.account += (string mess) => Console.WriteLine($"лямбда{mess}");
            creditCard2.Put(40);


        }
    }
}