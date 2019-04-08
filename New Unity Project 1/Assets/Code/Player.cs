using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    //血量設定

    public const int maxHealth = 100;

    static public int currentHealth = maxHealth;

    //血量條


    public RectTransform healthBar, hurt;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        CheckHpState();


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

        if (col.name == "eagle_flying(Clone)")
        {
            print("Player crashed, HP -10");
            //扣血
            currentHealth = currentHealth - 10;
            Destroy(col.gameObject);
        }
        else if (col.name == "opossum_run(Clone)")
        {
            print("Player crashed, HP -50");
            //扣血
            currentHealth = currentHealth - 50;
            Destroy(col.gameObject);
        }
        else if (col.name == "frog-idle")
        {
            print("Player crashed, HP -1");
            //扣血
            currentHealth = currentHealth - 1;
        }
        else if (col.name == "frog-jump")
        {
            print("Player crashed, HP -90");
            //扣血
            currentHealth = currentHealth - 90;
        }
        else if (col.name == "cherry(Clone)")
        {
            print("Player crashed, HP +20");
            //補血
            currentHealth = currentHealth + 20;
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



}
