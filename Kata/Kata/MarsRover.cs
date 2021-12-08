using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class MarsRover
    {
        private int[] poss;
        private string dir;
        public int[] posicion { set { poss = value; } get { return poss; } }
        public string direccion { set { dir = value; } get { return dir; } }

        public MarsRover(int[] posicion, string direcion)
        {
            this.direccion = direcion;
            this.posicion = posicion;
        }

        public bool ejecutarComandos(object comandos)
        {
            if (!(comandos is string[]))
            {
                return false;
            }

            string[] comandoAEjecutar = ((string[])comandos)[0].Split(' ');

            switch (comandoAEjecutar[0])
            {
                case "avanzarParaAdelante":
                    posicion[0] = posicion[0] + int.Parse(comandoAEjecutar[1]);    
                    break;
                default:
                    return false;
                    break;
            }

            return true;
        }
    }
}
