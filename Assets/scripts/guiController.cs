using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startClicked()
	{
		Application.LoadLevel("Main");
	}

	public void exitClicked()
	{
		print("CLicked");
		Application.Quit ();
	}
}
