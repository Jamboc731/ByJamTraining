using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : InputManager
{
    
    private void Update()
    {
        GetInputs();
        SetVectors();
    }

    private void GetInputs()
    {
        f_xIn = Input.GetAxisRaw("Horizontal");
        f_zIn = Input.GetAxisRaw("Vertical");
        f_mX = Input.GetAxis("Mouse X");
        f_mY = Input.GetAxis("Mouse Y");

    }

    private void SetVectors()
    {
        v3_moveVector.x = f_xIn;
        v3_moveVector.z = f_zIn;
        v3_cameraVector.x = f_mX;
        v3_cameraVector.y = f_mY;
    }
}
