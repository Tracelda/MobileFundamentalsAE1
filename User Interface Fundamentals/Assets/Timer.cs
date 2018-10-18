using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private Text TimerTXT;
    public float Time; 


	// Use this for initialization
	void Start ()
    {
        TimerTXT = GameObject.Find("Timer").GetComponent<Text>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void FixedUpdate()
    {
        Timer
    }
}
