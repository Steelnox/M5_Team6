using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Team6
{
    public class Junior : Empleado
    {
        public Junior(Empleado emple)
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

            if (salario_mes <= 900 || salario_mes >= 1600)
            {
                Console.WriteLine("El salario de este empleado se cambiará al mínimo de esta categoría");
                salario_mes = 901;
            }
        }


    }
}
