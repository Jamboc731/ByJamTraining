using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveableEntity : EntityBase
{

    protected Rigidbody rb;

    public override void Init()
    {
        rb = GetComponent<Rigidbody>();
    }

}
