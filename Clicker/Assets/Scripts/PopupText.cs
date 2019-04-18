using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupText : MonoBehaviour
{
    public float moveSpeed;
    public float popupNumber;
    public Text displayNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayNumber.text = popupNumber.ToString("#.00");
        transform.position = new Vector2(transform.position.x, transform.position.y + (moveSpeed * Time.deltaTime));
    }
}
