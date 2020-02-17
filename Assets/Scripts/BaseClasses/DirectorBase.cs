using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorBase : MonoBehaviour
{

    //Methods
    #region Protected

    /// <summary>
    /// The list of all the managers attached to this director
    /// </summary>
    protected Dictionary<string, ManagerBase> s_mbD_managers = new Dictionary<string, ManagerBase>();

    #endregion

    #region Serialised


    #endregion

    //Methods
    #region Protected Voids


    #endregion

    #region Public Voids

    public void Init()
    {
        Debug.Log("initialising: " + GetType().ToString());
    }

    #endregion

}
