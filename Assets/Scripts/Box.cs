using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, IInteractable
{
    EPickupStates ECurrentState;
    // Start is called before the first frame update
    void Start()
    {
        ECurrentState = EPickupStates.putdown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact(Collider col)
    {
        switch (ECurrentState)
        {
            case EPickupStates.putdown:
                transform.parent = col.transform;
                ECurrentState = EPickupStates.pickedup;
                break;
        }
    }

    public void Deinteract()
    {
        switch (ECurrentState)
        {
            case EPickupStates.pickedup:
                transform.parent = null;
                ECurrentState = EPickupStates.putdown;
                break;
        }
    }

}
