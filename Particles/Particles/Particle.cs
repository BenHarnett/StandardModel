using System;

namespace Particles
{
    /// <summary>
    /// A fundamental unit of the universe.
    /// https://en.wikipedia.org/wiki/List_of_particles
    /// </summary>
    public abstract class Particle
    {
        public enum ParticleTypes
        {
            Fermions,
            Bosons,
            Hadrons
        }

        public abstract float Mass { get; set; }

        /// <summary>
        /// An intrinsic form of angular momentum.
        /// https://en.wikipedia.org/wiki/Spin_(physics)
        /// </summary>
        public abstract double Spin { get; }

        public abstract string Name { get; }

        public abstract ParticleTypes ParticleType { get; }
    }
}
