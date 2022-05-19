using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_decorador_Gonzalo_figlioli
{
    public abstract class AgregadoDecorator : BurgerComponent
    {
        protected BurgerComponent _burger;
        public AgregadoDecorator(BurgerComponent burger)
        {
            _burger = burger;
        }
    }
}
