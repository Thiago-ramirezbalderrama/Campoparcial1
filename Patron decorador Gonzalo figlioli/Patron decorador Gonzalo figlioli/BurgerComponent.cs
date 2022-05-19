using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_decorador_Gonzalo_figlioli
{
    public abstract class BurgerComponent
    {
        public abstract double precio { get; }
        public abstract string Descripcion { get; }
    }
}
