using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript3 : MonoBehaviour
{
    public GameObject nextHealth;
    public Image image;



    void OnTriggerEnter2D(Collider2D other)
    {
        image.color = new Color32(255, 153, 0, 255);
        nextHealth.SetActive(true);
        gameObject.SetActive(false);
    }

}
