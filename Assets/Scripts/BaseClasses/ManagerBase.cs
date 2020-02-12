using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The base class for all managers except bp ABV: mb
/// </summary>
public abstract class ManagerBase : MonoBehaviour
{

    /// <summary>
    /// The initialise function for managers
    /// </summary>
    public virtual void Init()
    {
        Debug.Log("initialising: " + GetType().ToString());
    }

}
