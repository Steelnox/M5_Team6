using System;

namespace M5_Team6
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manage = new Manager(new Empleado("Carlo",5000));
            Console.WriteLine(manage.ToString());
        }
    }
}
