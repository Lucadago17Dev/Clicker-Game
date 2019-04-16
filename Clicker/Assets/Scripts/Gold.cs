using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{


    public static float gold = 500.0f;
    public int cookies;
    public float mult = 1.0f;
    public float baseClick = 20;

    public GUIStyle guiStyle;
   
// Update is called once per frame
void Update()
    {
        cookies = addCookies.cookies;
        baseClick = cookies * .2f;

    }




    private void OnMouseDown()
    {
        gold = gold + (baseClick * mult);

    }

   
    void OnGUI()
    {
        guiStyle.fontSize = 20;
        GUI.Label(new Rect(10, 10, 100, 20),"Money : "+ gold.ToString("#.00"), guiStyle);
    }
}
