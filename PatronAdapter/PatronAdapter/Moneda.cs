using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public abstract class Moneda
    {

        public abstract void pagar();

        public abstract void aumentoMoneda();

        public abstract void bajaMoneda();


    }
}
