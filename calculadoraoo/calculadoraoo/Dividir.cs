using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraoo
{
    class Dividir
    {

        public int num1, n2, total;

        public Dividir()
        {
            Console.WriteLine("Objeto Dividir Criado");
        }
        public Dividir(int num1, int num2)
        {
            this.num1 = num1;
            this.n2 = num2;
            int total = num1 / num2;
            Console.WriteLine("Resultado da divisão: " + this.total);
        }

        public void DiviEterno()
        {

        }
    }
}
