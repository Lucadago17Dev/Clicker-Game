using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public static float coins = 50;
    public static float coinsOnClick = 1.5f;
    public GameObject popupNumber;
    public Text coinsOnClickText;
    public static float cps;

    public  GUIStyle guiStyle;

    public float timer;


    private void Start()
    {
        timer = 1;
        
    }

    void Update()
    {
        timer-=Time.deltaTime;
       if(timer<=0)
        {
            coins += cps;
            timer = 1;
            var cloneCps = (GameObject)Instantiate(popupNumber, transform.position, Quaternion.Euler(Vector2.zero));
            cloneCps.GetComponent<PopupText>().popupNumber = cps;

        }

    }

    private void OnMouseDown()
    {
        coins += coinsOnClick;
        coinsOnClickText.text = coinsOnClick.ToString("#.00");
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
