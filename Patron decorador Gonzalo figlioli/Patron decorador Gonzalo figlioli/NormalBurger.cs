using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_decorador_Gonzalo_figlioli
{
    public class NormalBurger : BurgerComponent
    {
        public override double precio => 200;
        public override string Descripcion => "Hamburguesa normal";
    }
}