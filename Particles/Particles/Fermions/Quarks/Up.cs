using System;
using System.Collections.Generic;
using System.Text;

namespace Particles.Fermions.Quarks
{
    public class Up : Quark
    {
        public override QuarkFlavours Flavour => QuarkFlavours.Up;

        public override float Mass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Name => "Up";
    }
}
