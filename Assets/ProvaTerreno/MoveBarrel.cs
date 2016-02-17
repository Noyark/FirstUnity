using UnityEngine;
using System.Collections;

public class MoveBarrel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(1, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
