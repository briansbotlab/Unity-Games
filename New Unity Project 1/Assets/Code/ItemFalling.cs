using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemFalling : MonoBehaviour
{

    public float spawnRatePerSec = 9.9f;  //每秒重生機率
    public float rateOfSpawn = 0.1f; //(反)重生機率

    public GameObject[] itemPrefabs;  //物品的種類

    public bool isRoundUp = false;
    public static int numForCheckRoundUp = 0;

    //掉落的X軸範圍[minPosX~maxPosX]
    public float minPosX = -7f;
    public float maxPosX = 7f;
    //掉落的Y軸
    public float posY = 5.5f;

    // Use this for initialization
    void Start()
    {
        //每秒呼叫一次SpawnEnemy
        InvokeRepeating("SpwanItem", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        CheckRoundUp();
        if (isRoundUp == true)
        {
            ChageChance();
        }
    }


    void SpwanItem()
    {

        //一定機率重生隨機一個敵人
        if (Random.value < spawnRatePerSec)
        {
            //生產裝備
            Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)],
            new Vector3(Random.Range(minPosX, maxPosX), posY, -0.1f), Quaternion.identity);
        }
    }

    void ChageChance()
    {

        if (rateOfSpawn < 0.9f)
        {
            rateOfSpawn = (float)((float)Score.currRound / 100);
        }

        if (spawnRatePerSec > 0.1f)
        {
            spawnRatePerSec = spawnRatePerSec - rateOfSpawn;
        }
    }

    void CheckRoundUp()
    {
        if (numForCheckRoundUp < Score.currRound)
        {
            isRoundUp = true;
            numForCheckRoundUp = Score.currRound;
        }
        else
        {
            isRoundUp = false;
        }
    }

}