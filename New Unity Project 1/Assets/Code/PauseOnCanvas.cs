using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOnCanvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnEnable()
    {
        //時間暫停
        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        //時間以正常速度運行
        Time.timeScale = 1f;
    }
}
