using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
  

    public static float gold = 500.0f;
    public int cookies;
    public float mult = 1.0f;
    public float baseClick = 20;

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
        GUI.Label(new Rect(10, 10, 100, 20), gold.ToString("#.00"));
    }
}
