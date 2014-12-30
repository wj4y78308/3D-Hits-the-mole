using UnityEngine;
using System.Collections;

public class gameControl : MonoBehaviour {
    public float rotate_speed = 1.0f; //how fast the object should rotate
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //ref:http://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0), Time.deltaTime * rotate_speed);
        }
	}
}
