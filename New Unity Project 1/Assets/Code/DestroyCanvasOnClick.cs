using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyCanvasOnClick : MonoBehaviour
{

    //要移除的canvas
    public GameObject canvas;


    void Start()
    {
        //按下按鈕時
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(ClickEvent);
    }

    void ClickEvent()
    {
        InstantiateCanvasOnClick.buttonState = true;



        Destroy(canvas);

    }
}
