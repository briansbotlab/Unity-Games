using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpShow : MonoBehaviour {

    public GameObject player;

    public Text HpText;

    //要產生的canvas

    public GameObject canvasPrefab;


    static public bool isPaused = false;


    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        //Player playerscript = player.GetComponent<Player>();

        

        HpText.text = "HP:"+ Player.currentHealth.ToString();
        if(Player.currentHealth == 0)
        {
            if (isPaused == false)
            {

                //生產canvasPrefab

                Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);

                isPaused = true;

            }
        }

    }
}
