using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_decorador_Gonzalo_figlioli
{
    public class BurgerSmash: BurgerComponent
    {
        public override double precio => 100;
        public override string Descripcion => "Hamburguesa Smasheada";
    }
}
