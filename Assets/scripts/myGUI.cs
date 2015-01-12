using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class myGUI : MonoBehaviour {
    public GUIStyle guiStyle;
    public Texture life_icon;
    public GameObject player_element_selector;
    public Texture[] elements_icon;
    public Texture[] digits_icon;
    public static int lifes = 5;
    public static int scores = 0;
    private int selected_element;
	private string[] tag;
    void Start() {
        initGame();
		tag = new string[]{"gold","wood",  "dirt", "water", "fire" };
    }

    void Update() {
        if (myGUI.lifes <= 0) {
            Time.timeScale = 0;
            molesPop.gameOver = true;
        }
        if (Input.GetKeyDown(KeyCode.R) && molesPop.gameOver)
            initGame();

		if (Input.GetAxis ("Mouse ScrollWheel")>0) {
			if(selected_element >0 ){
				selected_element--;
			}
			else{
				selected_element = 4;
			}
			player_element_selector.tag = tag[selected_element];
		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0) {
			if(selected_element <4 ){
				selected_element++;
			}
			else{
				selected_element = 0;
			}
			player_element_selector.tag = tag[selected_element];
		}
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
        GUILayout.Label("   " , guiStyle);
        for (int i = 0; i < scores.ToString().Length; i++) {
            GUI.DrawTexture(new Rect(100 - (scores.ToString().Length-i-1) * 20, 29, 20, 25), digits_icon[int.Parse(scores.ToString().Substring(i, 1))]);
        }
            GUILayout.EndHorizontal();

        GUILayout.EndArea();

        for (int i = 0; i < 5; i++) {
			Rect r; 
            if (i < selected_element){
				r=new Rect(Screen.width - 60, 10 + i * 52, 50, 50);
                GUI.DrawTexture(r, elements_icon[i]);
			}
			else if (i > selected_element){
				r=new Rect(Screen.width - 60, 10 + i * 52 + 10, 50, 50);
                GUI.DrawTexture(r, elements_icon[i]);
			}
			else{
				r=new Rect(Screen.width - 70, 10 + i * 52, 60, 60);
                GUI.DrawTexture(r, elements_icon[i]);
			}
			if(Input.GetMouseButton(0)){
				if (r.Contains(Event.current.mousePosition)){
					selected_element = i;
					player_element_selector.tag = tag[selected_element];
				}
			}
        }

        if (molesPop.gameOver)
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Game Over!\nPress 'R' restart!", guiStyle);
    }

    void initGame() {
        molesPop.gameOver = false;
        scores = 0;
        lifes = 5;
        scores = 0;
        Time.timeScale = 1;
        selected_element = 0;
        player_element_selector.tag = "gold";
    }
}
