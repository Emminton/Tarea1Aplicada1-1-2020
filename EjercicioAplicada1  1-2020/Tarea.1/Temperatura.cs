using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._1
{
    public class Temperatura
    {
        // metodo para convertir la Temperatura
        
            double centigrado, faren;
            string valor = "";

            public void carcularTemperatura()
            {
                Console.Write("Ingrse la temperatura a Convertir: ");
                valor = Console.ReadLine();
                centigrado = Convert.ToDouble(valor);

                faren = (centigrado * 9 / 5) + 32;

                Console.Write("La temperatura es:{0} ", faren);

                Console.ReadKey();
            }
    }
}
