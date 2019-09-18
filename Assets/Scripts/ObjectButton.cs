using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class ObjectButton : MonoBehaviour
{


    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
    public Material yellowMat;
    protected Material defaultMat;

    //  public OVRInput.Controller activeController; /*= OVRInput.Controller.None;*/

    // Use this for initialization
    void Start()
    {
        definedButton = this.gameObject;
        defaultMat = this.gameObject.GetComponent<Renderer>().material;
        // open = false;
    }

    // Update is called once per frame
    void Update()
    {
        //    activeController = OVRInput.GetLocalController(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTrackedRemote);

        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Ray ray = new Ray(transform.position, transform.forward);
        Ray ray = Camera.main.ScreenPointToRay(OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote));
        RaycastHit Hit;

        //if (Input.GetMouseButtonDown(0))
        //{
        //    // if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
        //    if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == definedButton)
        //    {
        //        Debug.Log("Button clicked");
        //        definedButton.transform.GetComponent<Renderer>().material = yellowMat;
        //        //            OnClick.Invoke();
        //    }
        //    else
        //        definedButton.transform.GetComponent<Renderer>().material = defaultMat;

        //    //if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        //    //{
        //    //    SceneManager.LoadScene("heart_01", LoadSceneMode.Single);
        //    //}
        //}


        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == definedButton)
            {
                definedButton.transform.GetComponent<Renderer>().material = yellowMat;
            }
            else
                definedButton.transform.GetComponent<Renderer>().material = defaultMat;
        }
        //    //if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTrackedRemote))
        //    //{
        //    //    if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
        //    //    {
        //    //        this.gameObject.GetComponent<Renderer>().material = yellowMat;
        //    //        // SceneManager.LoadScene("heart_01", LoadSceneMode.Single);
        //    //        OnClick.Invoke();
        //    //    }
        //    //    else
        //    //        this.gameObject.GetComponent<Renderer>().material = defaultMat;
        //    //}


    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    //void OnMouseDown()
    //{
    //    //if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTrackedRemote))
    //    //{
    //    //    definedButton.GetComponent<Renderer>().material = yellowMat;
    //    //}
    //    this.gameObject.GetComponent<Renderer>().material = yellowMat;

    //}

}
