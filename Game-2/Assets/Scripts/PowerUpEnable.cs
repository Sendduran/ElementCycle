using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class PowerUpEnable : MonoBehaviour
{
    public Button waterButton;
    public Button fireButton;
    public Button powerupButton;
    public Button windButton;
    public Button lightningButton;
    // en;
    PowerUpCounting puc;
    ObjectPooler op;


    //PowerUpCounting sn = gameObject.GetComponent<PowerUpCounting>();
    //PowerUpCounting puc = GameObject.FindGameObjectWithTag("PowerUpCounting").GetComponent<PowerUpCounting>();



    void Start()
    {
        puc = GameObject.FindGameObjectWithTag("PowerUpCounting").GetComponent<PowerUpCounting>();
        op = GameObject.FindGameObjectWithTag("ObjectPooler").GetComponent<ObjectPooler>();

    }

    public void PowerupReady()
    {
        Debug.Log("I am ready......");
        powerupButton.interactable = true;
        powerupButton.onClick.AddListener(() => EnemyDisable());
    }


    //Disables all active child objects and disables them
    public void EnemyDisable()
    {
        try
        {
            foreach (Transform child in op.transform)
            {
                child.gameObject.SetActive(false);
                puc.resetCount();
                powerupButton.interactable = false;

            }
        }

        catch (Exception ex)
        {
            Debug.Log("error is" + ex);
        }


    }

  



}
