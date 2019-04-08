using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour {

    public float spawnRatePerSec = 0.7f;  //每秒重生機率
    public GameObject[] enemyPrefabs;  //重生的敵人種類


    // Use this for initialization
    void Start () {
        //每秒呼叫一次SpawnEnemy
        InvokeRepeating("SpawnEnemy", 1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnEnemy()
    {
        //一定機率重生隨機一個敵人
        if (Random.value < spawnRatePerSec)
        {
            Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], transform.position, Quaternion.identity);
        }
    }

}
