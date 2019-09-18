using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeClick : MonoBehaviour {
    float speed = 40.0f;
    bool spin = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (spin)
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
	}

    public void OnClickStart()
    {
        spin = true;
    }

    public void OnClickStop()
    {
        spin = false;
    }
}
