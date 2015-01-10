using UnityEngine;
using System.Collections;

public class gameControler : MonoBehaviour {
    public float lifeTime; 
    public GameObject player_element_selector;


    // Use this for initialization
    void Start() {
        //transform.FindChild("default").rotation = transform.rotation;// new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z + 90);
       transform.FindChild("default").Rotate(new Vector3(0, 0, 90));
        player_element_selector = GameObject.Find("player");
        //transform.Translate(3, 1.5f, 0);
      //  transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        switch (player_element_selector.tag) {
            case "gold":
                transform.FindChild("default").renderer.material.color = Color.yellow;
                break;
            case "wood":
                transform.FindChild("default").renderer.material.color = Color.green;
                break;
            case "water":
                transform.FindChild("default").renderer.material.color = Color.blue;
                break;
            case "fire":
                transform.FindChild("default").renderer.material.color = Color.red;
                break;
            case "dirt":
                transform.FindChild("default").renderer.material.color = Color.gray;
                break;
        }
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
