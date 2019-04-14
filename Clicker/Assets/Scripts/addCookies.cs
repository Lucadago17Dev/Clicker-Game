using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addCookies : MonoBehaviour
{
    public static int cookies = 0;
    float gold;
    public float cost = 5.0f;
    float costMult = 2.0f;

    private void Update()
    {
        gold = Gold.gold;
    }
    private void OnMouseDown()
    {
        
        if (gold >= cost)
        {
            cookies++;
            Gold.gold -= cost;
            cost = cost + (cookies * costMult);

        }
        Debug.Log("gold = " + gold);
    }


}
