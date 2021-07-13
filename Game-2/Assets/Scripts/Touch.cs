using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{

    private bool isTouching = false;
    Rigidbody2D rb;
    new Camera camera;
    CircleCollider2D circleCollider;
         
    //public string currentElement;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        camera = Camera.main;
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartTouch();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopTouch();
        }

        if (isTouching)
        {
            UpdateTouch();
        }
                
    }

    void UpdateTouch()
    {
        Vector2 touchPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        rb.position = touchPosition;
    }

    void StartTouch()
    {
        isTouching = true;
        circleCollider.enabled = true;
    }
    void StopTouch()
    {
        isTouching = false;
        circleCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "Enemy_tag")
        //{
        //    switch (ElementToggle.currentElement)
        //    {
        //        case "fire":
        //            // collision.gameObject.SetActive(false);
        //            break;
        //        case "water":
        //            //    collision.gameObject.SetActive(false);
        //            break;
        //        case "wind":
        //            //  collision.gameObject.SetActive(false);
        //            break;
        //        case "earth":
        //            //  collision.gameObject.SetActive(false);
        //            break;
        //        case "lightning":
        //            collision.gameObject.SetActive(false);
        //            break;
        //    }
        //}

        if (collision.gameObject.tag == "fireEnemy" && ElementToggle.currentElement == "water")
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.tag == "waterEnemy" && ElementToggle.currentElement == "earth")
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.tag == "windEnemy" && ElementToggle.currentElement == "fire")
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.tag == "earthEnemy" && ElementToggle.currentElement == "lightning")
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.tag == "lightningEnemy" && ElementToggle.currentElement == "wind")
        {
            collision.gameObject.SetActive(false);
        }

        //if (collision.gameObject.tag == "Enemy_tag")
        //{
        //    Debug.Log(ElementToggle.currentElement);
        //    collision.gameObject.SetActive(false);           
        //    //Create switch case for elements

        //}
        //else
        //{
        //   // Debug.Log(collision.gameObject.tag);
        //}
    }
}
