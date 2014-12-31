using UnityEngine;
using System.Collections;


public class molesPop : MonoBehaviour {
	private string moleState;
	public int popup_rate = 5;
	public int stayTime = 500;
	public float popUp_speed = 0.15f;
	private int moveCounter=0;
	private int stayTimeCounter=0;
	// Use this for initialization
	void Start () {
		moleState = "sleep";
		stayTimeCounter = stayTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (moleState=="sleep") {
			if(Random.Range(0,1000) < popup_rate) 
				moleState = "pop"; 
		}
		else if(moleState == "pop"){
			if(moveCounter++ < 10){
				transform.Translate(new Vector3(0,popUp_speed,0));
			}
			else
				moleState = "stay";
		}
		else if(moleState == "stay"){
			if(stayTimeCounter-- < 0){
				moleState = "sink";
				stayTimeCounter = stayTime;
			}
		}
		else if(moleState == "sink"){
			if(moveCounter-- > 0){
				transform.Translate(new Vector3(0,-popUp_speed,0));
			}
			else
				moleState = "sleep";
		}
	}
}
