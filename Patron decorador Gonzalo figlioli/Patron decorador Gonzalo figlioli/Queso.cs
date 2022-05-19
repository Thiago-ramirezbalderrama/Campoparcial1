using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_decorador_Gonzalo_figlioli
{
    public class Queso : AgregadoDecorator
    {
        public Queso(BurgerComponent burger) : base(burger) { }
        public override double precio => _burger.precio + 30;
        public override string Descripcion => string.Format($"{_burger.Descripcion}, queso cheddar");
    }
}
