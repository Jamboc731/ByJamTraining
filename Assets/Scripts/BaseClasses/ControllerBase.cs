﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBase : MonoBehaviour
{

    #region Serialised


    #endregion

    #region Privates


    #endregion

    #region Protected


    #endregion

    protected InputManager im;
    protected Vector3 v3_moveVector;

    #region Unity Standards
    

    #endregion

    #region Private Voids

    /// <summary>
    /// Initialisation function for all controllers
    /// </summary>
    public virtual void Init()
    {
        Debug.Log("initialising: " + GetType().ToString());
    }

    #endregion

    #region Public Voids


    #endregion

    #region Private Returns


    #endregion

    #region Public Returns


    #endregion

    

}
