using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textTest : MonoBehaviour {

    Text test;
    bool flag;
	// Use this for initialization
	void Start () {
        test = GetComponent<Text>();
        test.text = "パナップさいとう";
        flag = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            //textManager.Instance.playText("試し");
        }
	}
}
