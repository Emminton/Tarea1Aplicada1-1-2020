using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EjercicioAplicada1__1_2020.Tarea._3
{
    public class Exepciones
    {

        //Ejercicio 3 del Capitulo 12
        public void ExcepcionesArreglos()
        {

            MessageBox.Show("FormatException.");
            MessageBox.Show("IndexOutOfBoundsRange");
            MessageBox.Show("ArrayTypeMismatchException");

        }

        public void ExcepcionesStream()
        {

            MessageBox.Show("DirectoryNotFoundException");
            MessageBox.Show("FileNotFoundException");
            MessageBox.Show("IOException");

        }

        public void ExcepcionesWriteLine()
        {

            MessageBox.Show("ExceptionToString");

        }
    }
}
