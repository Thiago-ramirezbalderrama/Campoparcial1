using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class Bitcoin
    {

        public void transferir()
        {
            Console.WriteLine("En bitcoin se tranfiere dinero ya que la moneda es intangible/no fisica");
        }

        public void subeValor()
        {
            Console.WriteLine("En btc su valor sube ya que hay mucha gente minando esta moneda");
        }

        public void bajaValor()
        {
            Console.WriteLine("en btc su valor baja ya que no hay mucha gente minando esta moneda");
        }

    }
}
