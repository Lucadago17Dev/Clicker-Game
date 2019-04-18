using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoneyObj1 : MonoBehaviour
{
    public float basePrice;
    public float price;
    public float costMultiplier;
    public float n = 0.0f;
    public float coins;
    public float clickMult;
    public static float clickMultiplier;


    
    

    
    void Update()
    {
        coins = MainController.coins;
        price = basePrice * Mathf.Pow(costMultiplier, n);
        
    }



    private void OnMouseDown()
    {
        if(price<=coins)
        {
            n++;
            MainController.coins -= price;
            clickMultiplier = clickMult * n;
        }
    }


    void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        GUI.Label(new Rect(position.x, Screen.height-position.y, 500, 20), "Cost : " + price.ToString("#.00"));
        GUI.Label(new Rect(position.x-100, Screen.height - position.y, 500, 20), "Level : " + n);
    }


}
