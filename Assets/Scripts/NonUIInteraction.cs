using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NonUIInteraction : MonoBehaviour {
    // public UnityEngine.UI.Text outText;
    public GameObject definedButton;
    protected Material oldHoverMat;
    public Material yellowMat;
    //bool changeColor = false;
    //void Start()
    //{

    //}
    //void Update()
    //{
    //    if (changeColor)
    //    {
    //        GetComponent<Renderer>().material = yellowMat;
    //        outText.text = "clicked on: " + gameObject.name;
    //    }
    //}

    //public void OnClickStart()
    //{
    //    changeColor = true;
    //}

    //public void OnClickStop()
    //{
    //    changeColor = false;
    //}


    public void OnHoverEnter()
    {
        //if(definedButton.transform.name == "heart_01"){
        oldHoverMat = definedButton.transform.GetComponent<Renderer>().material;
        definedButton.transform.GetComponent<Renderer>().material = yellowMat;
        //}

    }
    public void OnHoverExit()
    {
        // if (t.gameObject.name == "heart_01")
        definedButton.transform.GetComponent<Renderer>().material = oldHoverMat;
    }

    public void OnSelected()
    {
        // if (t.gameObject.name == "heart_01")
        if (definedButton.transform.name == "heart_01")
            SceneManager.LoadScene("heart_01", LoadSceneMode.Single);
        else if (definedButton.transform.name == "heart_02")
            SceneManager.LoadScene("heart_02", LoadSceneMode.Single);

    }


    //public void OnHoverEnter(Transform t)
    //{
    //        oldHoverMat = t.gameObject.GetComponent<Renderer>().material;
    //        t.gameObject.GetComponent<Renderer>().material = yellowMat;
    //}

    //public void OnHoverExit(Transform t)
    //{

    //        t.gameObject.GetComponent<Renderer>().material = oldHoverMat;

    //}

    //public void OnSelected(Transform t)
    //{
    //    if (t.gameObject.name == "heart_01")
    //    {
    //        SceneManager.LoadScene("heart_01", LoadSceneMode.Single);
    //    }

    //}
}
