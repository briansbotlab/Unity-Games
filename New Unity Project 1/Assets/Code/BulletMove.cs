using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
        
    }

    public float Speed = 5F;
   

    // Update is called once per frame
    void Update () {


            transform.Translate(Vector2.right * Time.deltaTime * Speed);
        //每秒移動(Speed)單位的距離


      


        Vector2 pos = transform.position;
     
    
      
            if (pos.x > 20 || pos.x < -20)
            {
                Destroy(gameObject);
                //刪除視窗外的物件
            }

        
        
    }
}
