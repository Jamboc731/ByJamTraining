using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBase : MonoBehaviour
{
    
    protected int i_health;
    protected int i_maxHealth;

    public virtual void Init()
    {
        Debug.Log("initialising: " + GetType().ToString());
    }

    public virtual void ChangeHealth(int _i_delta)
    {
        i_health += _i_delta;

        if (i_health >= i_maxHealth)
            i_health = i_maxHealth;
        else if (i_health <= 0)
            Die();

    }

    public virtual void Die()
    {
        Debug.Log(name + " DIED. POOL ME OR SOME SHIT.");
    }

}
