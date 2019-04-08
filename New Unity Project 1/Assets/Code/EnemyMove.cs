using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public int Speed = 5;
    public int minPosX = -8;
    public int maxPosX = 7;

    // Use this for initialization
    void Start () {
		
	}


    // Update is called once per frame
    void Update () {

        // 移動的距離
        float movement = Speed * -1 * Time.deltaTime;

        //新的座標
        Vector3 newPos = new Vector3(Mathf.Clamp(transform.position.x + movement,
            minPosX, maxPosX), transform.position.y, transform.position.z);

        //把座標設為新的座標
        transform.position = newPos;



        if (transform.position.x < -7 )
        {
            Destroy(gameObject);
            //刪除視窗外的物件
        }
    }
}
