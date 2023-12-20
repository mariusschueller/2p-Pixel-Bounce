using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour
{
    public GameObject nextHealth;
    public Image image;
    
    void Start()
    {
        image.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        nextHealth.SetActive(true);
        image.color = new Color32(153, 255, 0, 255);
        gameObject.SetActive(false);
    }

}
