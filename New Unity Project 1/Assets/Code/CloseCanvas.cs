using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseCanvas : MonoBehaviour {

    //要移除的canvas
    public GameObject canvas;


    // Use this for initialization
    void Start () {
        //按下按鈕時
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(ClickEvent);
    }

    void ClickEvent()
    {

        Destroy(canvas);

    }
}
