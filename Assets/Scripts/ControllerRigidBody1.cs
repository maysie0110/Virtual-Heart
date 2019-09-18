using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRigidBody1 : MonoBehaviour {

    //public GameObject go;
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;
    public float moveSpeed = 10;

    private Rigidbody rb;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    #region Monobehaviour API
    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        //transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);

        //if(Physics.Raycast(transform.position, transform.forward, out hit))
        //{
        //    if(hit.collider != null)
        //    {
        //        if(go != hit.collider.gameObject)
        //        {
        //            go = hit.transform.gameObject;
        //            Debug.Log("On ");
        //        }
        //    }
        //}

        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);
    }
    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        // transform.Translate(Vector3.forward * input * moveSpeed);
        rb.AddForce(transform.forward * input * moveSpeed, ForceMode.Force);
    }
    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }

    #endregion
}