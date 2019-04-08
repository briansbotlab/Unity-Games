using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Unit
{
    //血量設定

    public const int maxHealth = 100;

    static public int currentHealth = maxHealth;

    //血量條


    public RectTransform healthBar, hurt;


    //要產生的canvas

    public GameObject canvasPrefab;

    //check canvas is created
    public bool forCheck = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        CheckHpState();

        if (currentHealth == 0 && forCheck ==false) {
            Congratulations();
        }


        //將綠色血條同步到當前血量長度

        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);

        //呈現傷害量
        if (hurt.sizeDelta.x <= healthBar.sizeDelta.x)
        {
            hurt.sizeDelta = healthBar.sizeDelta;
        }
        else if (hurt.sizeDelta.x > healthBar.sizeDelta.x)
        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            hurt.sizeDelta += new Vector2(-1, 0) * Time.deltaTime * 10;

        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.name == "cherry(Clone)")
        {
            print("Boss crashed, HP +10");
            //補血
            currentHealth = currentHealth + 10;
            Destroy(col.gameObject);
        }


    }


    void CheckHpState()
    {

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        else if (currentHealth <= 0)
        {
            currentHealth = 0;

        }

    }


    void Congratulations() {
        //生產canvasPrefab

        Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);
        forCheck = true;

    }
}
