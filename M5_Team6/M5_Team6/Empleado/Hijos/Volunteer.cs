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
            this.salario_bruto_mes = 0;
            this.reduccion = 0;

            CalculoSalario();
        }

        protected override void CalculoSalario()
        {
            if (salario_bruto_mes > 300 )
            {
                Console.WriteLine("Los voluntarios solo pueden recibir una ayuda de hasta 300 euros");
                salario_bruto_mes = 300;
            }

            CalcularIRPF();

            CalcularSueldoAnual();
        }

        protected override void CalcularSueldoAnual()
        {
            salario_bruto_anual = salario_bruto_mes * 12;

            salario_neto_anual = salario_neto_mes * 12;

            Console.WriteLine("Los voluntarios no tienen incremento anual");
        }
    }
}
