using System;
using System.Collections.Generic;
using System.Text;

namespace Particles.Fermions
{
    public abstract class Fermion : Particle
    {
        public override ParticleTypes ParticleType { get { return ParticleTypes.Fermions; } }
    }
}
