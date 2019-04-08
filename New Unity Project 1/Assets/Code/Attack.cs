using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Attack : MonoBehaviour {

    public GameObject[] bullet;//子彈物件

    static public int bullet_type = 0;

    // Use this for initialization
    void Start () {
		
	}
    
  
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
            //GameObject CloneBullet = (GameObject)Instantiate(Bullet,
            //transform.position, new Quaternion(0, 0, 0, 0));

            Instantiate(bullet[bullet_type], transform.position, transform.rotation);



            //Instantiate(Bullet, transform.position, new Quaternion(0, 0, 0, 0));
            //複製子彈物件在物件位置

        }

        if (Input.GetKeyDown(KeyCode.X))
        {

            if (bullet_type == 1)
            {
                bullet_type = 0;
            }
            else {
                bullet_type = 1;
            }

        }

    }



}
