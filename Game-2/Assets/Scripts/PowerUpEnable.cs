using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class PowerUpEnable : MonoBehaviour
{
    public Button waterButton;
    public Button fireButton;
    public Button earthButton;
    public Button windButton;
    public Button lightningButton;
    Enemy en;
    PowerUpCounting puc;



    //PowerUpCounting sn = gameObject.GetComponent<PowerUpCounting>();
    //PowerUpCounting puc = GameObject.FindGameObjectWithTag("PowerUpCounting").GetComponent<PowerUpCounting>();



    void Start()
    {
        puc = GameObject.FindGameObjectWithTag("PowerUpCounting").GetComponent<PowerUpCounting>();
    }


    public void FirePowerUpReady()
    {
        Debug.Log("I am ready......");
        fireButton.interactable = true;
    }
    public void WaterPowerUpReady()
    {
        Debug.Log("I am ready......");
        waterButton.interactable = true;                   
    }
    public void EarthPowerUpReady()
    {
        Debug.Log("I am ready......");
        earthButton.interactable = true;
    }
    public void WindPowerUpReady()
    {
        Debug.Log("I am ready......");
        windButton.interactable = true;
    }
    public void LightningPowerUpReady()
    {
        Debug.Log("I am ready......");
        lightningButton.interactable = true;
        lightningButton.onClick.AddListener(() =>EarthEnemyDisable());
    }



    //common method to disable enemy 
    public void EnemyDisable(string enemyname) {

        try
        {
            en = GameObject.Find(enemyname).GetComponent<Enemy>();
            en.disableEnemy();
        }

        catch (Exception ex)
        {
            Debug.Log("error is" + ex);
        }


    }


    //earth enemy disbale method
    public void EarthEnemyDisable()
    {

        EnemyDisable("Earth_Enemy");
        puc.resetCount();
        lightningButton.interactable = false;
      
    }

    //water enemy disable

    public void waterEnemyDisable()
    {

        EnemyDisable("Water_enemy");
        puc.resetCount();
        //lightningButton.interactable = false;

    }

    //wind enemy

    public void windEnemyDisable()
    {

        EnemyDisable("Wind_Enemy");
        puc.resetCount();
        //lightningButton.interactable = false;

    }

    //fire Enemy
    public void fireEnemyDisable()
    {

        EnemyDisable("Fire_Enemy");
        puc.resetCount();
        //lightningButton.interactable = false;

    }
    //lightning enemy 

    public void lightningEnemyDisable()
    {

        EnemyDisable("Lightning_Enemy");
        puc.resetCount();
        //lightningButton.interactable = false;

    }

   


}
