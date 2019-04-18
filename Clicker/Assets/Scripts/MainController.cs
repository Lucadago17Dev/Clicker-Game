using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public static float coins = 50;
    public float coinsOnClick;
    public GameObject popupNumber;
    public Text coinsOnClickText;

    public  GUIStyle guiStyle;


    void Update()
    {
        coinsOnClick = AddMoneyObj1.clickMultiplier;
        
    }

    private void OnMouseDown()
    {
        coins += coinsOnClick;
        coinsOnClickText.text = coinsOnClick.ToString();
        Vector3 range = new Vector3(Random.Range(-2.0f, 2.0f), 0, 0);
        var clone = (GameObject)Instantiate(popupNumber, transform.position-range, Quaternion.Euler(Vector2.zero));
        clone.GetComponent<PopupText>().popupNumber = coinsOnClick;
    }


    void OnGUI()
    {
        guiStyle.fontSize = 20;
        GUI.Label(new Rect(10, 10, 100, 20), "Money : " + coins.ToString("#.00"), guiStyle);
    }
}
