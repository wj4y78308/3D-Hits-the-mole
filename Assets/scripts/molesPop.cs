using UnityEngine;
using System.Collections;


public class molesPop : MonoBehaviour {
	private int     popup_rate      = 5;
    private float   popUp_speed     = 0.15f;
	private int     stayTime        = 100;
	private int     onHitStayTime   = 30;
	private string  moleState;
    private bool    isHit;
	private int     moveCounter     = 0;
	private int     stayTimeCounter = 0;

	// Use this for initialization
	void Start () {
        isHit = false;
		moleState = "sleep";
		stayTimeCounter = stayTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (moleState=="sleep") {
            if (Random.Range(0, 1000) < popup_rate) {
                moleState = "pop";
                renderer.material.color = Color.red;
            }
		}
		else if(moleState == "pop"){
			if(moveCounter++ < 10){
                transform.Translate(new Vector3(0, popUp_speed, 0)); 
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
        else if (moleState == "sink") {
            if (moveCounter-- > 0) {
                transform.Translate(new Vector3(0, -popUp_speed, 0));
            }
            else {
                if (!isHit) myGUI.lifes--;
                moleState = "sleep";
                isHit = false;
            }
        }

	}

    void OnMouseDown() {
        renderer.material.color = Color.blue;
        transform.Translate(new Vector3(0, (10 - moveCounter) * popUp_speed, 0));
        myGUI.scores++;

        isHit = true;
        moveCounter = 10;
        moleState = "stay";
        stayTimeCounter = onHitStayTime;
    }
}
