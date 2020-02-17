using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : ControllerBase
{
    InputManager im;
    public void Init()
    {
        // This should mean that on init, it gets the next available input manager
        Director imDirector = BigPapa.x.GetDirector("InputManager");
        im = (InputManager)BigPapa.x.GetManager("InputManager", imDirector.GetAvailableKey());
    }
    

}
