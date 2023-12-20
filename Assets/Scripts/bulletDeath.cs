using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDeath : MonoBehaviour
{
    public GameObject particleDeath;
    private Rigidbody2D rb;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        
        
        if (transform.position.x > 2.45)
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }

        if (transform.position.x < -2.45)
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(particleDeath, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            particleDeath.SetActive(true);

            /*healthP1 = PlayerPrefs.GetInt("HealthP1");
            healthP1 = healthP1 - 10;
            PlayerPrefs.SetInt("HealthP1", healthP1);*/
        }

        else if (other.CompareTag("Untagged"))
        {
            Destroy(gameObject);
        }
    }
}
