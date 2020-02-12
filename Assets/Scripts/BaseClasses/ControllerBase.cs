using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBase : MonoBehaviour
{
    protected InputManager im;
    protected Vector3 v3_moveVector;

    protected void Start()
    {

    }

    public virtual void Init()
    {
        Debug.Log("initialising: " + GetType().ToString());
    }

    protected void Update()
    {

    }
}
