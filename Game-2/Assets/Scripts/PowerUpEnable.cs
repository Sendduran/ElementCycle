using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpEnable : MonoBehaviour
{
    public Button waterButton;
    public Button fireButton;
    public Button earthButton;
    public Button windButton;
    public Button lightningButton;

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
    }

}
