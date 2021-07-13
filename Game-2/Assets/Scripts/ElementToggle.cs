using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementToggle : MonoBehaviour
{

    //public ToggleGroup ElementPicker;
    //public Toggle isWater;
    //public Toggle isFire;
    //public Toggle isWind;
    //public Toggle isEarth;
    //public Toggle isLightning;  
    public static string currentElement;
    public void OnWaterClicked(bool waterClicked)
    {
        if (waterClicked)
        {
         currentElement = "water";
         Debug.Log("Waterclicked");
        }
        
    }

    public void OnFireClicked(bool fireClicked)
    {
        if (fireClicked)
        {
            currentElement = "fire";
            Debug.Log("Fireclicked");
        }
        
    }
    public void OnWindClicked(bool windClicked)
    {
        if (windClicked)
        {
            currentElement = "wind";
            Debug.Log("WindClicked");
        }
       
    }

    public void OnEarthClicked(bool earthClicked)
    {
        if (earthClicked)
        {
            currentElement = "earth";
            Debug.Log("EarthClicked");
        }
       
    }

    public void OnLightningClicked(bool lightningClicked)
    {
        if (lightningClicked)
        {
            currentElement = "lightning";
            Debug.Log("LighningClicked");
        }
        
    }

//public void ActiveToggle()
//    {

//        if (isWater.isOn)
//        {            
//            Debug.Log("Water");
//        }
//        else if (isFire.isOn)
//        {
//            Debug.Log("Fire");
//        }
//        else if (isWind.isOn)
//        {
//            Debug.Log("Wind");
//        }
//        else if (isEarth.isOn)
//        {
//            Debug.Log("Earth");
//        }       
//        else if (isLightning.isOn)
//        {
//            Debug.Log("Lightning");
//        }
//        if (ElementPicker.AnyTogglesOn())
//        {
//            Debug.Log("Element Changed");
//        }
//    }


    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.gameObject.tag == "touch")
    //    {
    //        Touch touch = collision.GetComponent<Touch>();
    //        touch.currentElement = this.gameObject.name;
    //        Debug.Log(this.gameObject.name);
    //    }
    //}

}
