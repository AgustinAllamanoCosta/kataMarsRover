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

        public MarsRover(int[] posicion, string direcion) {
            this.direccion = direcion;
            this.posicion = posicion;
        }

    }
}
