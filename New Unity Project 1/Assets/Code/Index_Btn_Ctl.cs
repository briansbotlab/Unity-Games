using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Index_Btn_Ctl : MonoBehaviour
{

    string btn_name;

    public static bool indexButtonState = true;

    //canvas help
    public GameObject canvas_help;


    // Use this for initialization
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);


        btn_name = btn.name;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnClick()
    {

        if (btn_name == "Button_Start")
        {



            Debug.Log("Button_Start");
            Time.timeScale = 1;

            //重製
            SetPlayerInitState();
            SceneManager.LoadScene("level1");



        }
        else if (btn_name == "Button_Exit")
        {

            Debug.Log("Button_Exit");
            Application.Quit();

        }
        else if (btn_name == "Button_Help")
        {

            Debug.Log("Button_Help");

            //生產canvas

            Instantiate(canvas_help, Vector2.zero, Quaternion.identity);


        }
        else
        {

            Debug.Log("Button Clicked. ClickHandler.");
        }


    }

    void SetPlayerInitState()
    {
        InstantiateCanvasOnClick.buttonState = true;
        Player.currentHealth = 100;
        Score.currScore = 0;
        Attack.bullet_type = 0;
        HpShow.isPaused = false;
        Boss.currentHealth = 100;
        RoundNum.currRoundText = 1;
    }

}
