using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpCounting : MonoBehaviour
{
    public static int waterCount, fireCount, windCount, earthCount, lightningCount;
    public static int powerUpLimiter = 9;
    PowerUpEnable pue;
    
    void Start()
    {
        pue = GameObject.FindGameObjectWithTag("PowerUpButton").GetComponent<PowerUpEnable>();
    }



    public int AddWaterCount()
    {
        if (waterCount <= powerUpLimiter)
        {
            if (waterCount == powerUpLimiter)
            {
                Debug.Log("power up is ready");
                pue.WaterPowerUpReady();
                waterCount += 1; // adding since no more use of if condition until power up used
            }
            else
            {
                waterCount += 1;
                Debug.Log(waterCount);
            }
        }
        return waterCount;
    }



    public int AddFireCount()
    {
        if (fireCount <= powerUpLimiter)
        {
            if (fireCount == powerUpLimiter)
            {
                Debug.Log("I am powerfull");
                pue.FirePowerUpReady();
                fireCount += 1; // adding since no more use of if condition until power up used
            }
            else
            {
                fireCount += 1;
                Debug.Log(fireCount);
            }
        }
        return fireCount;
    }

    public int AddWindCount()
    {
        if (windCount <= powerUpLimiter)
        {
            if (windCount == powerUpLimiter)
            {
                Debug.Log("I am powerfull");
                pue.WindPowerUpReady();
                windCount += 1; // adding since no more use of if condition until power up used
            }
            else
            {
                windCount += 1;
                Debug.Log(windCount);
            }
        }
        return windCount;
    }

    public int AddEarthCount()
    {
        if (earthCount <= powerUpLimiter)
        {
            if (earthCount == powerUpLimiter)
            {
                Debug.Log("I am powerfull");
                pue.EarthPowerUpReady();
                earthCount += 1; // adding since no more use of if condition until power up used
            }
            else
            {
                earthCount += 1;
                Debug.Log(earthCount);
            }
        }
        return earthCount;
    }

    public int AddLightningCount()
    {
        if (lightningCount <= powerUpLimiter)
        {
            if (lightningCount == powerUpLimiter)
            {
                Debug.Log("I am powerfull");
                pue.LightningPowerUpReady();
                lightningCount += 1; // adding since no more use of if condition until power up used
            }
            else
            {
                lightningCount += 1;
                Debug.Log(lightningCount);
            }
        }
        return lightningCount;
    }
}