using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._1
{
    public class Radianes
    {
        //En este metodo se carcula de grados a Radianes
        
            double grados, radianes, pi = 3.1416, r = 0.0;
            string valor = "";

            public void CarcularRadianes()
            {

                Console.Write("Ingrese la cantida de grados a convertir:");
                valor = Console.ReadLine();
                grados = Convert.ToDouble(valor);

                radianes = (grados * pi / 180);

                Console.Write("los radianes son{0}: ", radianes);


                Console.ReadKey();
            }


            // Este metodo es para carcular el las Divisa
            public void CalcularDivisa()
            {
                double dolar, tasa = 0.89775, euro;
                string valor = "";

                Console.Write("Ingrese la cantida de dola para cambiar: ");
                valor = Console.ReadLine();
                dolar = Convert.ToDouble(valor);

                euro = (dolar * tasa);

                Console.Write("Lacantidad de EURO es: {0} ", euro);

                Console.ReadKey();
            }
            // metodo para elevar a la potencia
            public void Potencia()
            {
                double num, resultado, potencia;
                string valor = "";

                Console.Write("Digite el numero que quiere elevar: ");
                valor = Console.ReadLine();
                num = Convert.ToDouble(valor);

                Console.Write("Digite el numero de la potencia: ");
                valor = Console.ReadLine();
                potencia = Convert.ToDouble(valor);

                resultado = Math.Pow(num, potencia);

                Console.Write("La potencia del " + num + " elevada " + potencia + " El resultado es: {0}", resultado);

                Console.ReadKey();
            }

        }
    }
