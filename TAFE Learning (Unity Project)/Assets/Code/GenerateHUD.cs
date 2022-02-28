using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHUD : MonoBehaviour
{
    public GUIContent rectContent;
    public Rect rectangle = new Rect(Screen.width / 2, Screen.height / 2, 100, 90);
    private void OnGUI()
    {
        GUI.Box(rectangle, rectContent);

        if(GUI.Button(new Rect(20, 40, 80, 20), "Debug Message") == true)
        {
            Debug.Log("Button has been clicked.");
        }
    }
}
