using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class myGUI : MonoBehaviour {
    public GUIStyle guiStyle;
    public static int lifes;
    public static int scores;

    void Start() {
        lifes = 3;
        scores = 0;
    }

    void Update() {

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
    }
}
