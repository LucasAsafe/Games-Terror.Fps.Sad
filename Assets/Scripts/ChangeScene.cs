﻿using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour 
{
    public string Sentimentos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    void OnMouseDown()
    {
        Application.LoadLevel(Sentimentos);
    }

}
