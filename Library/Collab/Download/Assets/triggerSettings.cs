using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerSettings : MonoBehaviour {

    public Image ButtonImage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnGazeStart()
    {
        ButtonImage.color = Color.green;
    }
}
