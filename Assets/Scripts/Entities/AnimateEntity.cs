using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateEntity : MoveableEntity
{
    public string s_inputId;
    [SerializeField]
    float f_moveSpeed;
    private ControllerBase im;


    public override void Init()
    {
        base.Init();
        //im = (ControllerBase)BigPapa.x.GetManager(s_inputId);
    }

    private void Move()
    {
        //AddForce(im.GS_v3_CameraVector, f_moveSpeed);
    }

}
