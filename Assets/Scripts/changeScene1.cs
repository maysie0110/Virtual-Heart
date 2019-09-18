using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene1 : MonoBehaviour {

    bool buttonPressed = false;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            buttonPressed = true;
        }

        if (buttonPressed && (OVRInput.GetUp(OVRInput.Button.One) || OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger)))
        {
            buttonPressed = false;
            Scene scene = SceneManager.GetActiveScene();

            if (scene.name == "heart_01")
            {
#if UNITY_ANDROID && !UNITY_EDITOR
		        OVRManager.PlatformUIConfirmQuit();
#endif
            }
            else
            {
                SceneManager.LoadScene("heart_01", LoadSceneMode.Single);
            }
        }

        if (OVRInput.GetUp(OVRInput.Button.One) || OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            buttonPressed = false;
        }
    }
}
