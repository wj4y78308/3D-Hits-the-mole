using UnityEngine;
using System.Collections;

public class gameControler : MonoBehaviour {
    public float lifeTime;

    // Use this for initialization
    void Start() {
        transform.Translate(0, 1.5f, 0);
        //var mousePos = Input.mousePosition;
        ////mousePos.x -= Screen.width / 2;
        ////mousePos.y -= Screen.height / 2;
        //transform.position = mousePos;
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update() {
      //  transform.Translate(new Vector3(-Input.GetAxis("Mouse X") * MouseSensitive, Input.GetAxis("Mouse Y") * MouseSensitive, 0));
        //Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //pz.z = 0;
        //print(pz);
        //transform.position = pz;
        
    }
}
