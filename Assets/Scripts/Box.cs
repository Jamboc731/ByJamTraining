using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, IInteractable
{
    IInteractable.EPickedUpState ECurrentState;
    // Start is called before the first frame update
    void Start()
    {
        ECurrentState = IInteractable.EPickedUpState.putdown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact(Collider col)
    {
        switch (ECurrentState)
        {
            case IInteractable.EPickedUpState.putdown:
                transform.parent = col.transform;
                ECurrentState = IInteractable.EPickedUpState.pickedup;
                break;
        }
    }

    public void Deinteract()
    {
        switch (ECurrentState)
        {
            case IInteractable.EPickedUpState.pickedup:
                transform.parent = null;
                ECurrentState = IInteractable.EPickedUpState.putdown;
                break;
        }
    }

}
