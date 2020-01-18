using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._1
{
    public class Poligono
    {
        double cantidadLado = 0, lado = 0, resultado = 0.0;
        string valor = "";
        public void CarcularPerimetro()
        {
            Console.Write("Digite el la cantida de lado:");
            valor = Console.ReadLine();
            cantidadLado = Convert.ToDouble(valor);

            Console.Write("Digite la longitu del lado: ");
            valor = Console.ReadLine();
            lado = Convert.ToDouble(valor);

            resultado = cantidadLado * lado;

            Console.WriteLine("El resultado del perimetro: {0}", resultado);

            Console.ReadKey();
        }

        // metodo Para imprimir si el numero es par o impar
        public void NumeroPar_Impar()
        {
            int num;
            string valor = "";

            Console.Write("Digite el numero: ");
            valor = Console.ReadLine();
            num = Convert.ToInt32(valor);

            if (num % 2 == 0)
                Console.WriteLine("el numero es par {0}....", num);
            else
                Console.WriteLine("El numero es impar {0}....", num);

            Console.ReadKey();

        }

        //Metodo de la tabla de multiplicar

        public void Tabla()
        {
            int num;
            string valor = "";

            do
            {
                Console.Write("Dgite el numero de la tabla que decea ver : ");
                valor = Console.ReadLine();
                num = Convert.ToInt32(valor);

            } while ((num < 1) || (num > 10));

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} =  {2} ", num, i, (num * i));

            }

            Console.ReadKey();
        }


        // metodo carcular el area y el perimetro de cualquie poligono regular
        public void AreayPerimetro()
        {
            double cantidadLado = 0, lado = 0, resultado = 0.0;
            double perimetro = 0, apotema = 0;

            string valor = "";
            int opci;


            Console.Write("Diguite 1 para el PERIMETRO y 2 Para el AREA...  ");
            valor = Console.ReadLine();
            opci = Convert.ToInt32(valor);

            if (opci == 1)
            {
                Console.Write("Digite el la cantida de lado\n:");
                valor = Console.ReadLine();
                cantidadLado = Convert.ToDouble(valor);

                Console.Write("Digite la longitu del lado: ");
                valor = Console.ReadLine();
                lado = Convert.ToDouble(valor);

                resultado = (cantidadLado * lado);

                Console.WriteLine("\n\nEl resultado del perimetro: {0}", resultado);
            }
            else
            {

                Console.Write("\nDiguite el perimertro: ");
                valor = Console.ReadLine();
                perimetro = Convert.ToDouble(valor);

                Console.Write("\nDigite el apotema: ");
                valor = Console.ReadLine();
                apotema = Convert.ToDouble(valor);

                resultado = (perimetro * apotema) / 2;

                Console.WriteLine("\nEl area del poligono es: {0}", resultado);

                Console.ReadKey();
            }
        }
    }
}
