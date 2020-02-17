using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : ControllerBase
{

    public override void Init(InputManager _im, MoveableEntity _me)
    {
        im = _im;
        me = _me;
    }

    private void Update()
    {
        GetMoveVector();
        MoveEntity();
    }

}
