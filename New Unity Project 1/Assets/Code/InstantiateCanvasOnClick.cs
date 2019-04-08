using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InstantiateCanvasOnClick : MonoBehaviour
{
    //要產生的canvas

    public GameObject canvasPrefab;

    public static bool buttonState = true;

    void Start()
    {
        //按下按鈕時
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(ClickEvent);
    }
    void Update()
    {
        if (buttonState)
        {
            this.GetComponent<Button>().interactable = true;
        }
        else
        {
            this.GetComponent<Button>().interactable = false;
        }


    }
        void ClickEvent()
    {
        buttonState = false;

        //生產canvasPrefab

        Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);
    }
}
