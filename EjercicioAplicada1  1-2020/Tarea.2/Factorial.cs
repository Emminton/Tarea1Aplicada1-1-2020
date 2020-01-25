using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._2
{
    public class Factorial
    {

        // 4 del Capitulo 5
        public void calcularFactorial(int numero)
        {
            double resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            Console.WriteLine("El factorial de " + numero + " es: " + Math.Round(resultado, 2));
            Console.ReadKey();
        }
    }
}
