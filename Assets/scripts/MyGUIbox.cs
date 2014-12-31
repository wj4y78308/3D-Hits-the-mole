using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MyGUIbox : MonoBehaviour {

    //按鈕文字
    public string text;
    //大小位置
    public Rect position;
    //深度
    public int depth;
    //顏色及透明度
    public Color color = Color.white;
    //是否啟用
    public bool isEnabled = true;
    //樣式設置
    public GUIStyle style;

    void OnGUI() {

        GUI.color = color;
        GUI.depth = depth;
        GUI.enabled = isEnabled;

        GUI.Box(position, text, style);
    }
}
