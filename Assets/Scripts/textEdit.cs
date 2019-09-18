using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textEdit : MonoBehaviour {

    [SerializeField] private Text description = null;
    string part1 = "part 1";
    string part2 = "The aorta can be spotted on top of the heart with it's red arch." +
            "It is the human body's largest artery that extends down to the abdomen; supplying" +
            "the body with oxygenated blood throughout all arteries";

    // Use this for initialization
    void Start () {
        description.text = part1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            description.text = part2;
        }
        else
            description.text = part1;
    }
}
