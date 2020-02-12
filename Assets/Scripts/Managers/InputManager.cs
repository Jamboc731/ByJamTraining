using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manager for player input ABV: im
/// </summary>
public class InputManager : ManagerBase
{

    #region Serialised


    #endregion

    #region Private

    /// <summary>
    /// X value for Keyboard/Controller.
    /// </summary>
    protected float f_xIn;
    /// <summary>
    /// Y value for Keyboard/Controller.
    /// </summary>
    protected float f_zIn;
    /// <summary>
    /// X value for Mouse.
    /// </summary>
    protected float f_mX;
    /// <summary>
    /// Y value for Mouse.
    /// </summary>
    protected float f_mY;

    /// <summary>
    /// Users controller/keyboard inputs
    /// </summary>
    protected Vector3 v3_moveVector;
    /// <summary>
    /// Users mouse inputs
    /// </summary>
    protected Vector3 v3_cameraVector;
    #endregion

    #region Get/Set

    public Vector3 GS_v3_MoveVector { get { return v3_moveVector; } private set { v3_moveVector = value; } }
    public Vector3 GS_v3_CameraVector { get { return v3_cameraVector; } private set { v3_cameraVector = value; } }

    #endregion


}
