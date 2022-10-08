namespace Homework_10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void GetAccess(Employee employee, AccesLevelType accesLevelType)
            {
                Type type = employee.GetType();
                Object[] attributes=type.GetCustomAttributes(true);
                foreach (Object attribute in attributes)
                    if((attribute is AccesLevelAttribute accesLevelAttribute)&&(accesLevelAttribute.accesLevelType>=accesLevelType))
                    { Console.WriteLine("Доступ к данным разрешён");
                    return;}
                Console.WriteLine("Доступ к данным запрещён");
                        
            }

            Worker worker = new Worker();
            GetAccess(worker, AccesLevelType.low);
            GetAccess(worker, AccesLevelType.high);

            Manager manager = new Manager();
            GetAccess(manager, AccesLevelType.high);
            GetAccess(manager, AccesLevelType.medium);

            Director director = new Director();
            GetAccess(director, AccesLevelType.medium);
            GetAccess(director, AccesLevelType.high);
        }
    }
}