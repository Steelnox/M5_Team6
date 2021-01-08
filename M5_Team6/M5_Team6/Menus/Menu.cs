using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Team6
{

    //CLASE MENU, sirve para mostrar el menu y que el usuario pueda ver lo introducido
    public class Menu
    {
        public void MostrarMenu()
        {
            string opcion = "";
            string metodo = "";
            string nombre = "";
            double sueldo = 0;
            Console.WriteLine("*******************BIENVENIDO A LA BASE DE DATOS DE LA EMPRESA*******************");
            Console.WriteLine("Opción 1: Boss");
            Console.WriteLine("Opción 2: Manager");
            Console.WriteLine("Opción 3: Senior");
            Console.WriteLine("Opción 4: Employee");
            Console.WriteLine("Opción 5: Mid");
            Console.WriteLine("Opción 6: Junior");
            Console.WriteLine("Opción 7: Volunteer");

            Console.WriteLine("Escoge que tipo de usuario quieres ver de entre las opciones que hay");
            opcion = Console.ReadLine();
            Console.WriteLine("Escoge si quieres escribir los valores o que me los invente yo: (Opcion 1 --> Escribir, Opcion 2 --> Inventar)");
            metodo = Console.ReadLine();
            if (metodo == "1")
            {
                Console.WriteLine("Introduce el nombre del empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Introduce el sueldo bruto del empleado");
                sueldo = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        Boss bs = new Boss(new Empleado(nombre, sueldo));
                        Console.WriteLine(bs.ToString());
                        break;
                    case "2":
                        Manager manag = new Manager(new Empleado(nombre, sueldo));
                        Console.WriteLine(manag.ToString());
                        break;
                    case "3":
                        Senior sen = new Senior(new Empleado(nombre, sueldo));
                        Console.WriteLine(sen.ToString());
                        break;
                    case "4":
                        Employee emplo = new Employee(new Empleado(nombre, sueldo));
                        Console.WriteLine(emplo.ToString());
                        break;
                    case "5":
                        Mid mi = new Mid(new Empleado(nombre, sueldo));
                        Console.WriteLine(mi.ToString());
                        break;
                    case "6":
                        Junior jun = new Junior(new Empleado(nombre, sueldo));
                        Console.WriteLine(jun.ToString());
                        break;
                    case "7":
                        Volunteer volun = new Volunteer(new Empleado(nombre, sueldo));
                        Console.WriteLine(volun.ToString());
                        break;
                    default:
                        Console.WriteLine("La opcion que seleccionaste es incorrecta, vuelve a intentarlo más tarde");
                        break;
                }
            }

            else if (metodo == "2")
            {
                switch (opcion)
                {
                    case "1":
                        Boss bs = new Boss(new Empleado("Jose", 100000));
                        Console.WriteLine(bs.ToString());
                        break;
                    case "2":
                        Manager manag = new Manager(new Empleado("Eric", 4500));
                        Console.WriteLine(manag.ToString());
                        break;
                    case "3":
                        Senior sen = new Senior(new Empleado("Gerardo", 5000));
                        Console.WriteLine(sen.ToString());
                        break;
                    case "4":
                        Employee emplo = new Employee(new Empleado("Sergio", 200));
                        Console.WriteLine(emplo.ToString());
                        break;
                    case "5":
                        Mid mi = new Mid(new Empleado("Alberto", 630));
                        Console.WriteLine(mi.ToString());
                        break;
                    case "6":
                        Junior jun = new Junior(new Empleado("Gumersinda", 6000));
                        Console.WriteLine(jun.ToString());
                        break;
                    case "7":
                        Volunteer volun = new Volunteer(new Empleado("Laia", 500));
                        Console.WriteLine(volun.ToString());
                        break;
                    default:
                        Console.WriteLine("La opcion que seleccionaste es incorrecta, vuelve a intentarlo más tarde");
                        break;
                }
            }

            else Console.WriteLine("Opcion invalida. Vuelve a intentarlo más tarde");
        }

    }
}
