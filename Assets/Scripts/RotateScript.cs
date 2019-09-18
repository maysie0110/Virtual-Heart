using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

    //GameObject myObject;
    //Vector3 objRotation = new Vector3(0f, 0f, 0f);
    //float rotateSpeed = 20f;

    void Start()
    {
    }

     void Update()
    {
        //Heart spinning itself
         transform.Rotate(new Vector3(0,Time.deltaTime * 20, 0)); 

        //float mouseX = Input.GetAxis("Mouse X");
        //if(mouseX != 0f)
        //{
        //    objRotation.y += mouseX * Time.deltaTime * rotateSpeed;
        //    myObject.transform.rotation = Quaternion.Euler(objRotation);
        //}

    }
}
