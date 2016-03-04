using UnityEngine;
using System.Collections;

public class MoveBarrel : MonoBehaviour {

    const float standardVelocity = 1f / 30f;
    const float superVelocity = 1f / 15f;
    const float hyperVelocity = 1f;
    
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        // Set the velocity of barrel
        float v = standardVelocity;
        if (Input.GetKey(KeyCode.P))
        {
            if (Input.GetKey(KeyCode.O))
                v = hyperVelocity;
            else
                v = superVelocity;
        }

        // Manage movement
	    if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector3(-v, 0, -v), Space.Self);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector3(-v, 0, v), Space.Self);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector3(v, 0, -v), Space.Self);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(v, 0, v), Space.Self);
        if (Input.GetKey(KeyCode.Q))
            transform.Translate(new Vector3(0, v, 0), Space.Self);
        if (Input.GetKey(KeyCode.Z))
            transform.Translate(new Vector3(0, -v, 0), Space.Self);

        float rv = 1f;
        // Manage rotate
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(new Vector3(-1, 0, 1), rv, Space.Self);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0, 1, 0), rv, Space.Self);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0, 1, 0), -rv, Space.Self);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(new Vector3(-1, 0, 1), -rv, Space.Self);
	}
}
