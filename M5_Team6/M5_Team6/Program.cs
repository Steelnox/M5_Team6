using System;

namespace M5_Team6
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manage = new Manager(new Empleado("Carlo",5000));
            Boss bs = new Boss(new Empleado("Eric", 7000));
            Employee emplo = new Employee(new Empleado("Gerardo", 2000));
            Volunteer volunt = new Volunteer(new Empleado("Sergio", 100000));
            Console.WriteLine(manage.ToString());
            Console.WriteLine(bs.ToString());
            Console.WriteLine(emplo.ToString());
            Console.WriteLine(volunt.ToString());

        }
    }
}
