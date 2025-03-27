using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy (string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
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
            foreach (char l in name)
            {
                int i = 0;
                if (i >= 8)
                    {
                        string modifiedname += name[i];
                        i++;
                    }
            }
            return modifiedname;
        }

        public void TakeDamage (float damage)
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
    }
}