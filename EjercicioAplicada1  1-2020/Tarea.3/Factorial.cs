using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._3
{
    public class Factorial
    {
        public double CalcularFactorial(double numero)
        {
            return numero = (numero < 2) ? numero : numero * CalcularFactorial(numero - 1);
        }
    }
}
