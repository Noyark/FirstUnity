﻿using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -1);
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up, 1);
            }
            else
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    transform.Rotate(Vector3.left, -1);
                }
                else
                {
                    if (Input.GetKey(KeyCode.DownArrow))
                    {
                        transform.Rotate(Vector3.left, 1);
                    }
                }
            }
        }
	}
}
