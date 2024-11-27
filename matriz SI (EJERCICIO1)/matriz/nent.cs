using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class nent
    {
        private int n;
        public nent()
        {
            n = 0;
        }
        public void cargar(int dato)
        {
            n = dato;
        }
        public int descargar()
        {
            return n;
        }
        public bool veriffibo()
        {
            if (n == 0 || n == 1)
                return true;

            int fibonacciAnterior = 0;
            int fibonacciActual = 1;

            while (fibonacciActual <= n)
            {
                if (fibonacciActual == n)
                    return true;

                int siguienteFibonacci = fibonacciAnterior + fibonacciActual;
                fibonacciAnterior = fibonacciActual;
                fibonacciActual = siguienteFibonacci;
            }

            return false;
        }
    }
}
