﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        GameObject fart = Instantiate(Resources.Load("Sound_Fart")) as GameObject;
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
