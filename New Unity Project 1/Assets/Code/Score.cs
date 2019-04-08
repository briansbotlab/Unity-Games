using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    static public int initialScore; //初始分數
    public static int currScore; //現在的分數

    public static int currRound = 1; //現在的Round

    // Use this for initialization
    void Start()
    {

        //設定初始分數
        initialScore = 0;
        currScore = initialScore;

    }

    // Update is called once per frame
    void Update()
    {

        //顯示(更變text的文字)
        GetComponent<Text>().text = "Score:" + currScore.ToString();


        if (currScore >= 100* currRound) {
            UpdataCurrentRound();
            RoundNum.currRoundText = 1 + currRound;
            
            
        }

    }

    void UpdataCurrentRound() {

        currRound = currScore / 100;

    }

}