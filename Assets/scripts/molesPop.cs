﻿using UnityEngine;
using System.Collections;


public class molesPop : MonoBehaviour {
    public static bool    gameOver  = false;

    public GameObject explosion;
    public GameObject Hammer;
    public int      popup_rate;
    private float   popUp_speed     = 0.2f;
	private int     stayTime        = 500;
	//private int     onHitStayTime   = 30;
	private string  moleState;
    private bool    isHit;
	private int     moveCounter     = 0;
	private int     stayTimeCounter = 0;
    private string[] tags;

	// Use this for initialization
	void Start () {
        isHit = false;
		moleState = "sleep";
		stayTimeCounter = stayTime;

        tags = new string[]{"fire", "water", "wood", "gold", "dirt"};
        gameObject.tag = tags[Random.Range(0, 4)] ;
        setColor(gameObject.tag);
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameOver) {
            if (moleState == "sleep") {
                collider.enabled = false;
               // renderer.material.color = Color.green;
                if (Random.Range(0, 10000) < popup_rate) {
                    isHit = false;
                    moleState = "pop";
                    gameObject.tag = tags[Random.Range(0, 4)];
                    setColor(gameObject.tag);
                    //renderer.material.color = Color.red;
                }
            }
            else if (moleState == "pop") {
                if (moveCounter++ < 10) {
                    transform.Translate(new Vector3(0, popUp_speed, 0));
                }
                else
                    moleState = "stay";
            }
            else if (moleState == "stay") {
                collider.enabled = true;
                if (stayTimeCounter-- < 0) {
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
                }
            }
        }

	}

    void OnMouseDown() {
        if (!gameOver && !isHit) {
            Instantiate(Hammer, transform.position, transform.rotation);

            //renderer.material.color = Color.black;
//            transform.Translate(new Vector3(0, (10 - moveCounter) * popUp_speed, 0));
            Instantiate(explosion, transform.position, transform.rotation);
            transform.Translate(new Vector3(0, -(moveCounter-1) * popUp_speed, 0)) ;
            myGUI.scores++;

            isHit = true;
            moveCounter = 0;
            moleState = "sleep";
            //stayTimeCounter = onHitStayTime;
        }
    }

    void setColor(string s) {
        switch (s) {
            case "fire":
                renderer.material.color = Color.red;
                break;
            case "water":
                renderer.material.color = Color.blue;
                break;
            case "wood":
                renderer.material.color = Color.green;
                break;
            case "gold":
                renderer.material.color = Color.yellow;
                break;
            case "dirt":
                renderer.material.color = Color.grey;
                break;
            default:
                print("Mole's Tag ERROR!!!!!!!!!!!!!!!!!!!!");
                break;
        }

    }
}
