using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Team6
{
   public class Manager : Empleado
    {

       

        public override void CalculoSalario()
        {
            incremento = salario_mes * 0.10;
            salario_mes += incremento;
        }

    }
}
