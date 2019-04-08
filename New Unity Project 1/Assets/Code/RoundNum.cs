using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundNum : MonoBehaviour
{


    static public int initialRound; //初始
    public static int currRoundText; //現在的

    // Use this for initialization
    void Start()
    {
        //設定初始分數
        initialRound = 1;
        currRoundText = initialRound;
    }

    // Update is called once per frame
    void Update()
    {
        //顯示(更變text的文字)
        GetComponent<Text>().text = "Round : " + currRoundText.ToString();


        if (currRoundText == 100)
        {

            SceneManager.LoadScene("level101");
        }

    }

}
