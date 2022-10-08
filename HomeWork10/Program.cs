namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            
            TimerCallback tm = new TimerCallback(Count);
            

            Timer timer = new Timer(tm, num, 0, 1000);



            Console.ReadLine();


            static void Count(object obj)
            {
                int x = (int)obj;

                Console.WriteLine($"{x + x}");

            }
        }
    }
}