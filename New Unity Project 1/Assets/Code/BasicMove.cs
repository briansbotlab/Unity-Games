using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    public int Dir = 0;

    public int minPosX = -7;
    public int maxPosX = 7;


    public int minPosY = -3;
    public int maxPosY = 2;

    public Canvas HPcanvas;

    //Vector2 vec2 = new Vector2(0, 0);//x=0 , y=0

    Unit unit;
    //float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = GetComponent<Player>().Speed; //獲取Player組件中的Speed值


        if (Input.GetKey(KeyCode.LeftArrow))
        {




            //移動的距離
            float movement = -1 * speed * Time.deltaTime;

            //新的座標
            Vector3 newPos = new Vector3(Mathf.Clamp(transform.position.x + movement,
                minPosX, maxPosX), transform.position.y, transform.position.z);

            //把座標設為新的座標
            transform.position = newPos;



            //變換方向
            Dir = 1;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {


            //移動的距離
            float movement = speed * Time.deltaTime;

            //新的座標
            Vector3 newPos = new Vector3(Mathf.Clamp(transform.position.x + movement,
                minPosX, maxPosX), transform.position.y, transform.position.z);

            //把座標設為新的座標
            transform.position = newPos;


            //變換方向
            Dir = 0;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

            //往上

            //移動的距離
            float movement = 10;

            //新的座標
            Vector3 newPos = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + movement,
                minPosY, maxPosY), transform.position.z);

            //把座標設為新的座標
            transform.position = newPos;


        }
        /*
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime* speed); //往下
        }
        */
        Face();
    }

    void Face()
    {
        //transform.Rotate(new Vector3(0, 0, 0)); //Z軸旋轉0度
        //transform.Rotate(new Vector2(0, 0)); //X軸旋轉5度
        Vector3 rotate = transform.rotation.eulerAngles; //獲得遊戲物件當前的旋轉值
        if (Dir == 0)
        {

            //rotate.x = 0;
            //rotate.z = 0;

            transform.rotation = Quaternion.Euler(0, 0, 0);

            HPcanvas.transform.rotation = Quaternion.Euler(0, 0, 0);

            /*
            print("x:" + rotate.x);
            print("y:" + rotate.y);
            print("z:" + rotate.z);
            */
        }
        else if (Dir == 1)
        {


            //rotate.x = -180;
            //rotate.z = -180;
            transform.rotation = Quaternion.Euler(180, 0, 180);

            HPcanvas.transform.rotation = Quaternion.Euler(0, 0, 0);

            /*
            print("x:" + rotate.x);
            print("y:" + rotate.y);
            print("z:" + rotate.z);
            */
        }

    }

    public int getDir()
    {
        return Dir;
    }
}
