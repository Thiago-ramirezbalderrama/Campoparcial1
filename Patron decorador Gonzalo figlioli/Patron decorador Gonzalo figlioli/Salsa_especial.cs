using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_decorador_Gonzalo_figlioli
{
    public class Salsa_especial : AgregadoDecorator
    {
        public Salsa_especial(BurgerComponent burger) : base(burger) { }
        public override double precio => _burger.precio + 50;
        public override string Descripcion => string.Format($"{_burger.Descripcion}, Salsa especial");

    }
}
