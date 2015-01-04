using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
    public GameObject bullet;
    public Transform shotSpwan;


	// Use this for initialization
	void Start () {
	
	}

	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0)) {
            Instantiate(bullet, shotSpwan.position, shotSpwan.rotation) ;
        }

        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0), -(Time.deltaTime * 0.5f) * Mathf.Rad2Deg, Space.World);

	}
}
