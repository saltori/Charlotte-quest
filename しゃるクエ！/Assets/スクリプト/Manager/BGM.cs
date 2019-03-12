using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AudioManager.Instance.PlayBGM("メタナイトの逆襲");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
