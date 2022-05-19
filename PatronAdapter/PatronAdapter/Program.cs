using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dolar dolar = new Dolar();
            dolar.bajaMoneda();
            dolar.aumentoMoneda();
            dolar.pagar();

            Peso peso = new Peso();
            peso.bajaMoneda();
            peso.aumentoMoneda();
            peso.pagar();

            Euro euro = new Euro();
            euro.bajaMoneda();
            euro.aumentoMoneda();
            euro.pagar();

            Bitcoin btc = new Bitcoin();
            btc.bajaValor();
            btc.subeValor();
            btc.transferir();

            Console.ReadKey();
        }
    }
}
