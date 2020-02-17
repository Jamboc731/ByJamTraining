using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBase : MonoBehaviour
{

    #region Serialised


    #endregion

    #region Privates


    #endregion

    #region Protected

    protected Vector3 v3_moveVector;
    protected InputManager im;
    protected MoveableEntity me;

    #endregion


    #region Unity Standards
    

    #endregion

    #region Protected Voids

    /// <summary>
    /// Gets the move vector from the input manager
    /// </summary>
    protected virtual void GetMoveVector()
    {
        v3_moveVector = im.GS_v3_MoveVector.normalized;
    }

    protected virtual void MoveEntity()
    {
        me.AddForce(v3_moveVector, me.f_MoveSpeed * Time.deltaTime, ForceMode.Impulse);
    }

    #endregion

    #region Public Voids

    #region Init Overloads

    /// <summary>
    /// Initialisation function for all controllers
    /// </summary>
    public virtual void Init()
    {
        Debug.Log("initialising: " + GetType().ToString());
    }

    public virtual void Init(InputManager _im, MoveableEntity _me)
    {

    }

    #endregion

    #endregion

    #region Protected Returns


    #endregion

    #region Public Returns


    #endregion



}
