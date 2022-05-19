using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class BitcoinAdapter : Moneda
    {

        Bitcoin btc = new Bitcoin();
        public override void aumentoMoneda()
        {
            btc.subeValor();
        }

        public override void bajaMoneda()
        {
            btc.bajaValor();
        }

        public override void pagar()
        {
            btc.transferir();
        }
    }
}
