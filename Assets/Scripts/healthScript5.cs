using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript5 : MonoBehaviour
{
    public Image image;
    public GameObject player;
    public GameObject winner;
    public GameObject loser;



    void OnTriggerEnter2D(Collider2D other)
    {
        
        player.SetActive(false);
        if (loser.activeSelf == false)
        {
            winner.SetActive(true);
        }
        
    }

}
