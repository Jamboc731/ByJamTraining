using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBase : MonoBehaviour
{
    

    #region Serialised


    #endregion

    #region Privates


    #endregion

    #region Protected

    protected int i_health;
    protected int i_maxHealth;

    #endregion

    #region Private Voids


    #endregion

    #region Public Voids

    /// <summary>
    /// Initialisation function for all entities
    /// </summary>
    public virtual void Init()
    {
        Debug.Log("initialising: " + GetType().ToString());
    }

    /// <summary>
    /// The health change for the entities
    /// </summary>
    /// <param name="_i_delta">
    /// the change in the health
    /// </param>
    public virtual void ChangeHealth(int _i_delta)
    {
        i_health += _i_delta;

        if (i_health >= i_maxHealth)
            i_health = i_maxHealth;
        else if (i_health <= 0)
            Die();

    }

    /// <summary>
    /// The die functiuon for all entities
    /// </summary>
    public virtual void Die()
    {
        Debug.Log(name + " DIED. POOL ME OR SOME SHIT.");
    }

    #endregion

    #region Private Returns


    #endregion

    #region Public Returns


    #endregion


}
