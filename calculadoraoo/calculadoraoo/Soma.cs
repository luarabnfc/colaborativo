using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraoo
{
    class Soma
    {
        public Soma()
        {
            Console.WriteLine("Objeto Soma Criado.");
        }

        public Soma(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine("Resultado da Soma: " + total);
        }

        public void SomaEterna()
        {

        }
    }
}
