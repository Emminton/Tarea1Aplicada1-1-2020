using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._2
{
    public class PromedioArrayList
    {
      // ejercicio 1 del capitulo 7
        public void CalcularPromedioArrayList()
        {
            int salida = 0, cont = 0;
            float calificacion = 0.0f, maxima = 0.0f, minima = 100.0f, promedio = 0.0f;
            ArrayList calificaciones = new ArrayList();

            Console.Clear();

            try
            {
                while (salida != -1)
                {
                    Console.Write("\nIngrese la Calificacion {0}:", cont + 1, ":");
                    calificacion = Convert.ToSingle(Console.ReadLine());

                    calificaciones.Add(calificacion);

                    if (calificacion > maxima)
                        maxima = calificacion;
                    if (calificacion < minima)
                        minima = calificacion;
                    Console.WriteLine("Para terminar el programa ingrese -1 \n\n");
                    salida = Convert.ToInt32(Console.ReadLine());
                    cont++;

                }
              
                foreach (float dato in calificaciones)
                {
                    promedio += dato;
                }

                Console.WriteLine("El promedio de calificaciones es:" + (Math.Round(promedio / calificaciones.Count, 2)));
                Console.WriteLine("La calificacion mas alta es:" + maxima);
                Console.WriteLine("La calificacion mas baja es:" + minima);
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
                Console.ReadKey();
            }
        }
    }
}
