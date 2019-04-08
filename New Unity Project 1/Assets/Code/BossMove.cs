using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public int Speed = 6;
    public int minPosX = -6;
    public int maxPosX = 6;

    public static int gameObjectState = 0;
    public int bossFace = 0;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x == maxPosX)
        {
            //如果到最右邊 轉向
            bossFace = 1;
        }
        else if (this.transform.position.x == minPosX)
        {
            //如果到最左邊 轉向
            bossFace = 0;
        }


        if (bossFace == 1)
        {
            print("MoveToLeft!");
            MoveToLeft();
            
        }
        else if (bossFace == 0)
        {
            print("MoveToRight!");
            MoveToRight();
           
        }
        else
        {
            print("Start  MoveToRight");
            print(this.transform.position.x);
            MoveToRight();
        }
    }

    void MoveToLeft()
    {
        //向左
        transform.rotation = Quaternion.Euler(0, 0, 0);

        // 移動的距離
        float movement = Speed * -1 * Time.deltaTime;

        //新的座標
        Vector3 newPos = new Vector3(Mathf.Clamp(transform.position.x + movement,
            minPosX, maxPosX), transform.position.y, transform.position.z);

        //把座標設為新的座標
        transform.position = newPos;
    }

    void MoveToRight()
    {
        //向右
        transform.rotation = Quaternion.Euler(180, 0, 180);

        // 移動的距離
        float movement = Speed * Time.deltaTime;

        //新的座標
        Vector3 newPos = new Vector3(Mathf.Clamp(transform.position.x + movement,
            minPosX, maxPosX), transform.position.y, transform.position.z);

        //把座標設為新的座標
        transform.position = newPos;
    }

}