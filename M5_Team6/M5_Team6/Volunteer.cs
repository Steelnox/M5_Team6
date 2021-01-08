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

           
        }


    }
}
