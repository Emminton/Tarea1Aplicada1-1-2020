using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._3
{
    public class EstructuraTienda
    {

        //Ejercicio 1 capitulo 9
        public struct TiendaItems
        {
            public int CodigoBarra;
            public string NombreProducto;
            public int CantidadProducto;
            public double PrecioProducto;
            public string DepartamentoProducto;

            public TiendaItems(int codigoBarra, string nombreProducto, int cantidadProducto, double precioProducto, string departamentoProducto)
            {
                CodigoBarra = codigoBarra;
                NombreProducto = nombreProducto;
                CantidadProducto = cantidadProducto;
                PrecioProducto = precioProducto;
                DepartamentoProducto = departamentoProducto;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Codigo:" + CodigoBarra + "\nNombre:" + NombreProducto + "\nCantidad:" + CantidadProducto
                    + "\nPrecio:" + PrecioProducto + "\nDepartamento:" + DepartamentoProducto);
                return (sb.ToString());
            }
        }
    }
}
