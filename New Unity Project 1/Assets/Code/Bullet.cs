using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bullet : Unit {


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        print(ThisObject.name);
        print(col.name);

        if (ThisObject.name == "attack(Clone)" && col.name == "eagle_flying(Clone)")
        {
            Score.currScore += 10;
            Destroy(ThisObject);
            Destroy(col.gameObject);
        }
        else if (ThisObject.name == "attack_v2(Clone)" && col.name == "opossum_run(Clone)")
        {
            Score.currScore += 100;
            Destroy(ThisObject);
            Destroy(col.gameObject);

        }else if (col.name == "cherry(Clone)") {
            //do nothing
        }
        else if (col.name == "frog-jump")
        {
            Boss.currentHealth -= 5;
            Destroy(ThisObject);
        }
        else
        {

            Destroy(ThisObject);
        }
       


        print("Unit  crashed");


    }
}
