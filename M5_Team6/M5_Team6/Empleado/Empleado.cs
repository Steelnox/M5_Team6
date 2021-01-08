using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Team6
{
    public class Empleado
    {
        protected string id;
        protected string nombre;
        protected double salario_neto_mes;
        protected double salario_bruto_mes;
        protected double salario_neto_anual;
        protected double salario_bruto_anual;
        protected float reduccion;
        protected double incremento;
        protected float irpf;


        #region Constructores
        public Empleado()
        {
            this.id = GenerarId();
            this.nombre = "";
            this.salario_bruto_mes = 0;
            this.salario_neto_mes = 0;
            this.salario_bruto_anual = 0;
            this.salario_neto_anual = 0;
        }

        public Empleado(string nombre)
        {
            this.id = GenerarId();
            this.nombre = nombre;
            this.salario_bruto_mes = 0;
            this.salario_neto_mes = 0;
            this.salario_bruto_anual = 0;
            this.salario_neto_anual = 0;
        }

        public Empleado(string nombre, double salario_neto_mes)
        {
            this.id = GenerarId();
            this.salario_bruto_mes = salario_neto_mes;
            this.nombre = nombre;
            this.salario_neto_mes = 0;
            this.salario_bruto_anual = 0;
            this.salario_neto_anual = 0;
        }
        #endregion
        #region getset
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Salario_neto_mes { get => salario_neto_mes; set => salario_neto_mes = value; }
        public float Reduccion { get => reduccion; set => reduccion = value; }
        public double Salario_bruto_mes { get => salario_bruto_mes; set => salario_bruto_mes = value; }
        public double Salario_neto_anual { get => salario_neto_anual; set => salario_neto_anual = value; }
        public double Salario_bruto_anual { get => salario_bruto_anual; set => salario_bruto_anual = value; }
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

        protected virtual void CalculoSalario()
        {

        }

        public override string ToString()
        {
            return id.ToString() + " / "  + nombre.ToString() + " / El sueldo neto mensual es " + salario_neto_mes.ToString() + " euros / El sueldo bruto mensual es " + salario_bruto_mes.ToString() + " euros / El sueldo neto anual es " + salario_neto_anual.ToString() + " euros / El sueldo bruto anual es " + salario_bruto_anual.ToString();
        }


        protected void CalcularIRPF()
        {
            double irpf_sueldo = 0;
            irpf_sueldo = salario_bruto_mes * irpf;
            salario_neto_mes = salario_bruto_mes - irpf_sueldo;

            salario_neto_mes = Math.Round(salario_neto_mes, 2);

        }

        protected virtual void CalcularSueldoAnual()
        {
            double incremento_anual = 0;

            salario_bruto_anual = salario_bruto_mes * 12;

            salario_neto_anual = salario_neto_mes * 12;

            incremento_anual = salario_neto_anual * 0.1;

            salario_neto_anual += incremento_anual;

            salario_neto_anual = Math.Round(salario_neto_anual, 2);

        }
    }

}
