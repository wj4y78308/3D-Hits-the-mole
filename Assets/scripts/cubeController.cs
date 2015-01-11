using UnityEngine;
using System.Collections;

public class cubeController : MonoBehaviour {
    public float rotate_speed = 2.0f; //how fast the object should rotate
    int debug_i = 0;
    // Use this for initialization
    void Start() {
            transform.rotation = Quaternion.identity ;
    }

    // Update is called once per frame
    void Update() {

        //ref:http://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html
        if (Input.GetMouseButton(0)) {
            // ref:http://answers.unity3d.com/questions/581017/whats-the-function-to-replace-the-obsolete-rotatea.html
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0), -(Time.deltaTime * rotate_speed) * Mathf.Rad2Deg, Space.World);
            //  transform.RotateAroundLocal(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0), -(Time.deltaTime * rotate_speed));
        }
    }

    void OnMouseDown() {
        print(debug_i.ToString()+"click on Cube!");
        debug_i++;
    }
}
