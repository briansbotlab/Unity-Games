using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ExitOnClick : MonoBehaviour {

    //要移除的canvas
    public GameObject canvas;

    // Use this for initialization
    void Start()
    {

        //按下按鈕時
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(ClickEvent);
    }

    void ClickEvent()
    {
        //刪掉canvas
        Destroy(canvas);

        //結束
        Application.Quit();
    }
}
