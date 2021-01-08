using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Team6
{
    public class Employee : Empleado
    {
        public Employee(Empleado emple)
        {
            this.id = emple.Id;
            this.nombre = emple.Nombre;
            this.salario_mes = emple.Salario_mes;
            this.reduccion = 0.15f;

            CalculoSalario();
        }


        public override void CalculoSalario()
        {
            incremento = salario_mes * reduccion;
            salario_mes -= incremento;
            salario_mes = Math.Round(salario_mes, 2);
        }


    }
}
