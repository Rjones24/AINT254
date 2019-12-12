﻿using UnityEngine;


public class RayViewer : MonoBehaviour {

    public float weaponRange = 50f;                      

    public Camera fpsCam;


    void Start () 
    {
      
	}

	
	void Update () 
    {
        Vector3 lineOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

        Debug.DrawRay(lineOrigin, fpsCam.transform.forward * weaponRange, Color.green);
	}
}
