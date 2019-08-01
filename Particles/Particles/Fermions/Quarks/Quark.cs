using System;
using System.Collections.Generic;
using System.Text;

namespace Particles.Fermions.Quarks
{
    public abstract class Quark : Fermion
    {
        public enum QuarkFlavours
        {
            Up,
            Down,
            Charm,
            Strange,
            Top,
            Bottom
        }

        public override double Spin => 0.5;
        public abstract QuarkFlavours Flavour { get; }

    }
}
