﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mass : MonoBehaviour {
    public float posx, posy;
    public SpriteRenderer Mass;
	// Use this for initialization
	void Start () {
        Mass = GetComponent<SpriteRenderer>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Push()
    {
        mapChar.posx = posx;
        mapChar.posy = posy;
    }
}
