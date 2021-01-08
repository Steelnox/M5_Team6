using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Team6
{
    public class Volunteer : Empleado
    {
        public Volunteer(Empleado emple)
        {
            this.id = emple.Id;
            this.nombre = emple.Nombre;
            this.salario_mes = 0;
            this.reduccion = 0;

            CalculoSalario();
        }

        public override void CalculoSalario()
        {
            if (salario_mes !=0 )
            {
                Console.WriteLine("Este empleado es voluntario y no cobra");
                salario_mes = 0;
            }
        }
    }
}
