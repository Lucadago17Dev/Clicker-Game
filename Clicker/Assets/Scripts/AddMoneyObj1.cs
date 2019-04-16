using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoneyObj1 : MonoBehaviour
{
    float basePrice = 50.0f;
    public float price;
    public float multiplier = 1.07f;
    public float n = 0.0f;
   
    
    void Update()
    {
        price = basePrice * Mathf.Pow(multiplier, n);
    }



    private void OnMouseDown()
    {
        

    }


}
