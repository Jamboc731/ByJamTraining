using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerrControrller : MonoBehaviour
{

    #region Serialized

    [SerializeField] private float speed;
    [SerializeField] private float sensitivity;
    [SerializeField] private Camera cam;

    #endregion

    #region Privates

    private Rigidbody rb;

    private RaycastHit hit;
    private Vector3 yFlatten = new Vector3(1, 0, 1);
    private Vector3 yOnly = new Vector3(0, 1, 0);
    private Vector3 moveDir;

    private float xIn, zIn, mX, mY;

    #endregion

    private void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {

        ListenForInputs();

        UpdateMoveVector();


        transform.Rotate(transform.up * mX);
        cam.transform.localEulerAngles = transform.InverseTransformDirection(transform.right) * -mY;

    }

    private void ListenForInputs()
    {
        xIn = Input.GetAxisRaw("Horizontal");
        zIn = Input.GetAxisRaw("Vertical");
        mY = Mathf.Clamp(mY + Input.GetAxisRaw("Mouse Y") * sensitivity * Time.deltaTime, -85, 85);
        mX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;

        if (Input.GetMouseButton(0)) Interact();
    }

    private void UpdateMoveVector()
    {
        moveDir.x = xIn;
        moveDir.z = zIn;
        moveDir = transform.TransformDirection(moveDir).normalized * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDir, ForceMode.Impulse);
        rb.velocity *= 0.9f;
    }

    private void Interact()
    {
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 3))
        {
            IInteractable i = hit.collider.GetComponent<IInteractable>();
            if (i != null) i.Interact(GetComponent<Collider>());
        }

    }

}
