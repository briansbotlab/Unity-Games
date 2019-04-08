using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HomeOnClick : MonoBehaviour {

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
        InstantiateCanvasOnClick.buttonState = true;
        //刪掉canvas
        Destroy(canvas);

        //轉場
        SceneManager.LoadScene("Index");
    }
}
