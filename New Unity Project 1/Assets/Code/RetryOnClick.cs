using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryOnClick : MonoBehaviour
{
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

        //重製
        SetPlayerInitState();


        //轉場

        SceneManager.LoadScene("level1");
    }

     void SetPlayerInitState()
    {
        InstantiateCanvasOnClick.buttonState = true;
        Player.currentHealth = 100;
        Score.currScore = 0;
        Attack.bullet_type = 0;
        HpShow.isPaused = false;

    }
}
