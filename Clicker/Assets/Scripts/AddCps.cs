using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCps : MonoBehaviour
{
    public float coins;
    public float price;
    public float basePrice;

    public float costMultiplier;
    public float n = 0.0f;

    public float cpsMult;
    public float cps;
    public float ownCps;

    void Update()
    {
        coins = MainController.coins;
        price = basePrice * Mathf.Pow(costMultiplier, n);
    }

    private void OnMouseDown()
    {
        if (price <= coins)
        {
            n++;
            MainController.coins -= price;
            cps = Mathf.Pow(cpsMult, n);
            ownCps = gameObject.GetComponent<AddCps>().cps;
            MainController.cps += ownCps;
        }
    }

    void addCps()
    {

    }
}
