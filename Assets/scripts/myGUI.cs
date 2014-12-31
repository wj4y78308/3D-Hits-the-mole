using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class myGUI : MonoBehaviour {
    public GUIStyle guiStyle;
    public static int lifes = 13;
    public static int scores = 0;

    void Start() {
        lifes = 13;
        scores = 0;
        Time.timeScale = 1;
    }

    void Update() {
        if (myGUI.lifes <= 0) {
            Time.timeScale = 0;
            molesPop.gameOver = true;
        }
    }

    void OnGUI() {
        GUILayout.BeginArea(new Rect(20, 20, 100, Screen.height / 2));

        GUILayout.BeginHorizontal();
        GUILayout.Label("Lifes:"+lifes.ToString(), guiStyle);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Scores:"+scores.ToString(), guiStyle);
        GUILayout.EndHorizontal();

        GUILayout.EndArea();

        if (molesPop.gameOver)
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Game Over!", guiStyle);
    }
}
