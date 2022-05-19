using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    internal class Peso : Moneda
    {
        public override void aumentoMoneda()
        {
            Console.WriteLine("El peso aumenta su precio porque el banco no genera billetes");
        }

        public override void bajaMoneda()
        {
            Console.WriteLine("El peso disminuye su precio porque el banco genera muchos billetes");
        }

        public override void pagar()
        {
            Console.WriteLine("El peso se paga en efectivo ya que la moneda es fisica/tangible");
        }
    }
}
