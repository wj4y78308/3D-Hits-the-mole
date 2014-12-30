using UnityEngine;
using System.Collections;

public class gameControl : MonoBehaviour {
    public float rotate_speed ; //how fast the object should rotate

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        //ref:http://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html
        if (Input.GetMouseButton(0))
        {
            // ref:http://answers.unity3d.com/questions/581017/whats-the-function-to-replace-the-obsolete-rotatea.html
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0), -(Time.deltaTime * rotate_speed) * Mathf.Rad2Deg, Space.World);
          //  transform.RotateAroundLocal(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0), -(Time.deltaTime * rotate_speed));
        }
	}
}
