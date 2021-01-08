using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Team6
{
    public class Mid : Empleado
    {
        public Mid(Empleado emple)
        {
            this.id = emple.Id;
            this.nombre = emple.Nombre;
            this.salario_bruto_mes = emple.Salario_bruto_mes;
            this.reduccion = 0.10f;
            this.irpf = 0.15f;

            CalculoSalario();
        }


        protected override void CalculoSalario()
        {
            incremento = salario_bruto_mes * reduccion;
            salario_bruto_mes -= incremento;
            salario_bruto_mes = Math.Round(salario_bruto_mes, 2);

            if (salario_bruto_mes <= 1800 || salario_bruto_mes >= 2500)
            {
                Console.WriteLine("El salario de este empleado se cambiará al mínimo de esta categoría");
                salario_bruto_mes = 1801;
            }

            CalcularIRPF();

            CalcularSueldoAnual();
        }

    }
}
