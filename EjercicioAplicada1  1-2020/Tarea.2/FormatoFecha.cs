using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._2
{
    public class FormatoFecha
    {
        // 1 del Capitulo 8.  AM o FM seguido de dia, mes, año.
        public void MostrarFechaHora()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString("hh : mm tt  dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}
