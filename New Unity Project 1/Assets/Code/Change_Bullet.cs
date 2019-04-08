using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Change_Bullet : MonoBehaviour {

    public Sprite[] bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Attack.bullet_type == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = bullet[0];
           //"item-feedback-1"
        }
        else if (Attack.bullet_type == 1) {



            this.gameObject.GetComponent<SpriteRenderer>().sprite = bullet[1];
            //"enemy-death-1"
        }




    }
}
