using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCounting : MonoBehaviour
{
    public static int waterCount;
    public static int fireCount;
    public static int windCount;
    public static int earthCount;
    public static int lightningCount;




    public static int addWaterCount()
    {
        waterCount = waterCount + 1;
        Debug.Log(waterCount);
        return waterCount;
    }

    public static int addFireCount()
    {
        fireCount = fireCount + 1;
        Debug.Log(fireCount);
        return fireCount;
    }
    public static int addWindCount()
    {
        windCount = windCount + 1;
        Debug.Log(windCount);
        return windCount;
    }
    public static int addEarthCount()
    {
        earthCount = earthCount + 1;
        Debug.Log(earthCount);
        return earthCount;
    }
    public static int addLightningCount()
    {
        lightningCount = lightningCount + 1;
        Debug.Log(lightningCount);
        return lightningCount;
    }







}
