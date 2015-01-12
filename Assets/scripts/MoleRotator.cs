using UnityEngine;
using System.Collections;

public class MoleRotator : MonoBehaviour {
    public GameObject following;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.rotation = following.transform.rotation;
	}
}
