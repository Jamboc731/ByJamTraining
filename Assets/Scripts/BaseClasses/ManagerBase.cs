using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The base class for all managers except bp ABV: mb
/// </summary>
public abstract class ManagerBase : MonoBehaviour
{

    #region Private Voids


    #endregion

    #region Public Voids

    /// <summary>
    /// The initialise function for managers
    /// </summary>
    public virtual void Init()
    {
        Debug.Log("initialising: " + GetType().ToString());
    }

    #endregion

    #region Private Returns


    #endregion

    #region Public Returns


    #endregion


}
