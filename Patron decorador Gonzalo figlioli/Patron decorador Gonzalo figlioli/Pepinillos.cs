using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_decorador_Gonzalo_figlioli
{
    public class Pepinillos : AgregadoDecorator
    {
        public Pepinillos(BurgerComponent burger) : base(burger) { }
        public override double precio => _burger.precio + 80;
        public override string Descripcion => string.Format($"{_burger.Descripcion}, pepinillos");

    }
}
