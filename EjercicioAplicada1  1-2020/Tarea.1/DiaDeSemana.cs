using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._1
{
    public class DiaDeSemana
    {
        
        // Metodo Para decir el dia de la semana ingresa un numero de 1 al 7
        public void Semana()
        {
            int num;
            string valor = "";

            Console.Write("Digite el numero para saber el dia que es del 1 al 7: ");
            valor = Console.ReadLine();
            num = Convert.ToInt32(valor);

            if (num == 1)

                Console.Write("El Dia es Domingo..");

            else
                    if (num == 2)

                Console.Write("El Dia es Lunes..");
            else
                    if (num == 3)
                Console.Write("El Dia es Martes..");
            else
                    if (num == 4)
                Console.Write("El Dia es Miercoles..");
            else
                    if (num == 5)
                Console.Write("El Dia es Jueves..");
            else
                    if (num == 6)
                Console.Write("El Dia es Viernes..");
            else
                    if (num == 7)
                Console.Write("El Dia es Sabado..");


            Console.ReadKey();
        }


        // metodo edad mayor y edad menor
        public void MedirEdad()
        {
            double num = 0, acum = 0, edad = 0, mayor = 0, menor = 0, promedio = 0.0;

            Console.Write("Ingrese el numero de la cantida de edades que va a digitar: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("\nDiguite la edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    mayor = edad;
                    menor = edad;
                }

                if (edad > mayor)

                    mayor = edad;
                else
                    if (edad < menor)
                    menor = edad;


                acum += edad;
                promedio = acum / num;


            }
            Console.Write("\nEl promedio es: {0}", promedio);
            Console.Write("\nLa edad Mayor es: {0}", mayor);
            Console.Write("\nLa edad menor es: {0}", menor);

            Console.ReadKey();
        }
    }
}
