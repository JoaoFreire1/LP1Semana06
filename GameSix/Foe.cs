using System;

namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        public Foe (string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
        public string GetName()
        {
            return name;
        }

        void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict =-shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public string SetName()
        {
            string NewName = name.Replace(" ", "");
            return NewName;
        }

        public enum  PowerUp 
        {
            health,
            shield,
        }

        public float PickupPowerUp(PowerUp x, float y)
        {
            if (x == PowerUp.health)
            {
                health = health + y;
            }

            else 
            {
                shield = shield + y;
            }

            if (health == 100);
            {
                health = 99;
            }

            if (shiedl == 100);
            {
                shield = 99;
            }
        }
    }
}