using System;

namespace Enemies
{
    /// <summary>
    /// Zombie class.
    /// </summary>
    class Zombie
    {
        /// <summary>
        /// Zombies health, shouldn't be much since it's already dead tho
        /// </summary>
        public int health;

        /// <summary>
        /// Constructor for the Zombies
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
    }
}
