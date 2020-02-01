using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAplicada1__1_2020.Tarea._3
{
   
        //Ejercicio 4 del capitulo 9
        public class Enumeracion
        {
            private enum Neumaticos
            {
                Neumáticos_Anchos,
                NeumáticosXL,
                NeumáticosUsados,
                NeumáticosVerano,
                NeumáticosInvierno,
                NeumáticosTodoTerreno
            };

            public string AsignarValoresEImprimir(int valor)
            {
                Neumaticos MiNeumatico;


                switch (valor)
                {
                    case 0:
                        MiNeumatico = Neumaticos.Neumáticos_Anchos;
                        return MiNeumatico.ToString();
                        break;
                    case 1:
                        MiNeumatico = Neumaticos.NeumáticosUsados;
                        return MiNeumatico.ToString();
                        break;
                    case 2:
                        MiNeumatico = Neumaticos.NeumáticosVerano;
                        return MiNeumatico.ToString();
                        break;
                    case 3:
                        break;
                    case 4:
                        MiNeumatico = Neumaticos.NeumáticosTodoTerreno;
                        return MiNeumatico.ToString();
                        break;
                    case 5:
                        MiNeumatico = Neumaticos.NeumáticosInvierno;
                        return MiNeumatico.ToString();
                        break;
                    default:

                        break;
                }
                return null;
            }
        }
}
