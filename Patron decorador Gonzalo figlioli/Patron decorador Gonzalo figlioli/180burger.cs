using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_decorador_Gonzalo_figlioli
{
    public class _180burger: BurgerComponent
    {
        public override double precio => 400;
        public override string Descripcion => "hamburguesa de 180 gramos";
    }
}
