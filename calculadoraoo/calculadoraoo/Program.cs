using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria variavel da classe Div.
            Dividir div;

            //O operador "new" cria um objeto da classe;
            div = new Dividir( );

            div.num1 = 5;
            div.n2 = 15;
            div.total = div.num1 / div.n2;

            Console.WriteLine("Primeiro numero: " + div.num1);
            Console.WriteLine("Segundo numero: " + div.n2);

            Console.ReadKey();
        }
    }
}
