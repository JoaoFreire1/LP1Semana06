using System;

namespace GameSix
{

    public class Foe(string name){}
    {
        this.name = name; //name oculta this .name
        health = 100;
        shield = 0;
    }  

    string GetName()
    {
        return name;
    }

    void TakeDamage()
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
