using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Team6
{
    public class Empleado
    {
        protected string id;
        protected string nombre;
        protected double salario_mes;
        protected float reduccion;
        protected double incremento;


        #region Constructores
        public Empleado()
        {
            this.id = GenerarId();
            this.nombre = "";
            this.salario_mes = 0;
        }

        public Empleado(string nombre)
        {
            this.id = GenerarId();
            this.nombre = nombre;
            this.salario_mes = 0;
        }

        public Empleado(string nombre, double salario_mes)
        {
            this.id = GenerarId();
            this.salario_mes = salario_mes;
            this.nombre = nombre;
        }
        #endregion
        #region getset
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Salario_mes { get => salario_mes; set => salario_mes = value; }
        public float Reduccion { get => reduccion; set => reduccion = value; }
        #endregion

        private string GenerarId()
        {
            int aleatorio_generado;
            char letra;
            Random aleatorio = new Random();
            aleatorio_generado = aleatorio.Next(100000, 1000000);

            int resto = aleatorio_generado % 23;

            switch (resto)
            {
                case 0:
                    letra = 'T';
                    break;
                case 1:
                    letra = 'R';
                    break;
                case 2:
                    letra = 'W';
                    break;
                case 3:
                    letra = 'A';
                    break;
                case 4:
                    letra = 'G';
                    break;
                case 5:
                    letra = 'M';
                    break;
                case 6:
                    letra = 'Y';
                    break;
                case 7:
                    letra = 'F';
                    break;
                case 8:
                    letra = 'P';
                    break;
                case 9:
                    letra = 'D';
                    break;
                case 10:
                    letra = 'X';
                    break;
                case 11:
                    letra = 'B';
                    break;
                case 12:
                    letra = 'N';
                    break;
                case 13:
                    letra = 'J';
                    break;
                case 14:
                    letra = 'Z';
                    break;
                case 15:
                    letra = 'S';
                    break;
                case 16:
                    letra = 'Q';
                    break;
                case 17:
                    letra = 'V';
                    break;
                case 18:
                    letra = 'H';
                    break;
                case 19:
                    letra = 'L';
                    break;
                case 20:
                    letra = 'C';
                    break;
                case 21:
                    letra = 'K';
                    break;
                case 22:
                    letra = 'E';
                    break;
                default:
                    letra = '0';
                    break;
            }

            return Convert.ToString(aleatorio_generado) + letra;
        }

        public virtual void CalculoSalario()
        {

        }

        public override string ToString()
        {
            return id.ToString() + " / " + salario_mes.ToString() + " / " + nombre.ToString();

        }

    }

}
