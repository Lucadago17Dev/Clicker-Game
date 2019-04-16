using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
     float coins = 50;
    public float coinsOnClick;



    public GUIStyle guiStyle;


    void Update()
    {
        coinsOnClick = 20;
    }

    private void OnMouseDown()
    {
        coins += coinsOnClick;

    }


    void OnGUI()
    {
        guiStyle.fontSize = 20;
        GUI.Label(new Rect(10, 10, 100, 20), "Money : " + coins.ToString("#.00"), guiStyle);
    }
}
