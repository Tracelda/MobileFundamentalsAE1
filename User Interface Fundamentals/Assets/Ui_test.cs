using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_test : MonoBehaviour {

    // public GameObject TheText;
    private Text TXT_COMP;

	// Use this for initialization
	void Start () {
        TXT_COMP = GameObject.Find("Text").GetComponent<Text>();
        //TXT_COMP.text = "The Cake Is a Lie";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetText()
    {
        TXT_COMP.text = "The Cake Is a Lie";
    }

    public void SetText(string T)
    {
        TXT_COMP.text = T;
    }
}
