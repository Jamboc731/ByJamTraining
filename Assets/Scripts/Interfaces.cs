using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    //internal enum EPickedUpState { pickedup, putdown };
    void Interact(Collider col);
    void Deinteract();
}


//public class Interfaces : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//} 
