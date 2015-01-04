using UnityEngine;
using System.Collections;

public class bulletMove : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 0, -speed));
       
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag == "platformCube" || other.tag == "fire" || other.tag == "water" || other.tag == "wood" || other.tag == "gold" || other.tag == "dirt") {
          Destroy(gameObject);
            
        }
    }

}
