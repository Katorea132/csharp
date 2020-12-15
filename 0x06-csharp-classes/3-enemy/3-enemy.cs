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
        private int health;

        /// <summary>
        /// Constructor for the Zombies
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Another constructor 'cause why not
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }

        /// <summary>
        /// Get method for the health of the zombie
        /// </summary>
        /// <returns>The health of the zombie</returns>
        public int GetHealth() => this.health;
    }
}
