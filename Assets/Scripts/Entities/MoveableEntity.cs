using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveableEntity : EntityBase
{

    #region Serialised

    [SerializeField] protected float f_moveSpeed = 5;

    #endregion

    #region Protected

    protected Rigidbody rb;

    #endregion

    #region Gets&Sets

    public float f_MoveSpeed { get { return f_moveSpeed; } private set { f_moveSpeed = value; } }

    #endregion

    public override void Init()
    {
        rb = GetComponent<Rigidbody>();
    }

    #region public void AddForce()
    public void AddForce(Vector3 _v3_direction, float _f_force)
    {
        rb.AddForce(_v3_direction.normalized * _f_force);
    }

    public void AddForce(Vector3 _v3_direction, float _f_force, ForceMode _fm_forceMode)
    {
        rb.AddForce(_v3_direction.normalized * _f_force, _fm_forceMode);
    }

    #endregion

}
