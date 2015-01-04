using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class myGUI : MonoBehaviour {
    public GUIStyle guiStyle;
    public Texture life_icon;
    public GameObject player_element_selector;
    public Texture[] elements_icon;
    public static int lifes = 5;
    public static int scores = 0;
    private int selected_element;

    void Start() {
        initGame();
    }

    void Update() {
        if (myGUI.lifes <= 0) {
            Time.timeScale = 0;
            molesPop.gameOver = true;
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            selected_element = 0;
            player_element_selector.tag = "gold";
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            selected_element = 1;
            player_element_selector.tag = "wood";
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            selected_element = 2;
            player_element_selector.tag = "water";
        }
        if (Input.GetKeyDown(KeyCode.F)) {
            selected_element = 3;
            player_element_selector.tag = "fire";
        }
        if (Input.GetKeyDown(KeyCode.G)) {
            selected_element = 4;
            player_element_selector.tag = "dirt";
        }

        if (Input.GetKeyDown(KeyCode.R) && molesPop.gameOver)
            initGame();
    }

    void OnGUI() {
        GUILayout.BeginArea(new Rect(20, 20, 150, Screen.height / 2));

        GUILayout.BeginHorizontal();
        GUILayout.Label(" ");
        //GUILayout.Label("Lifes:"+lifes.ToString(), guiStyle);
        for (int i = 0; i < lifes; i++) 
            GUI.DrawTexture(new Rect(0+i*25, 0, 20, 20), life_icon);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Scores:"+scores.ToString(), guiStyle);
        GUILayout.EndHorizontal();

        GUILayout.EndArea();

        for (int i = 0; i < 5; i++) {
            if (i < selected_element)
                GUI.DrawTexture(new Rect(Screen.width - 60, 10 + i * 52, 50, 50), elements_icon[i]);
            else if (i > selected_element)
                GUI.DrawTexture(new Rect(Screen.width - 60, 10 + i * 52 + 10, 50, 50), elements_icon[i]);
            else
                GUI.DrawTexture(new Rect(Screen.width - 70, 10 + i * 52, 60, 60), elements_icon[i]);
        }

        if (molesPop.gameOver)
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Game Over!\nPress 'R' restart!", guiStyle);
    }

    void initGame() {
        molesPop.gameOver = false;
        scores = 0;
        lifes = 3;
        scores = 0;
        Time.timeScale = 1;
        selected_element = 0;
    }
}
