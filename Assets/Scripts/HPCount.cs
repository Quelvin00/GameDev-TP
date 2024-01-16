using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPCount : MonoBehaviour
{

    private int health = 100;
    [SerializeField] private Text HP;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            health -= 5;
            HP.text = "HP: " + health;
        }
    }
}
