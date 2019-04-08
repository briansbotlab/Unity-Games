using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour {

    public int Speed = 2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // 移動的距離
        float movement = Speed * -1 * Time.deltaTime;

        //新的座標
        Vector3 newPos = new Vector3(transform.position.x , transform.position.y + movement, transform.position.z);

        //把座標設為新的座標
        transform.position = newPos;



        if (transform.position.y < -3)
        {
            Destroy(gameObject);
            //刪除視窗外的物件
        }
    }
}
