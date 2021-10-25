using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class health_bar : MonoBehaviour
{
    private Image HealthBar;
    public float currentHealth;
    private float MaxHealth = 50f;
    Wall wall;

    private void Start() {

        HealthBar = GameObject.FindGameObjectWithTag("healthBar").GetComponent<Image>();
       
        wall = GameObject.FindGameObjectWithTag("wall").GetComponent<Wall>();

    }

    private void Update() {

        currentHealth = wall.Health;
        Debug.Log(currentHealth);
        HealthBar.fillAmount = currentHealth / MaxHealth;



    }
}
