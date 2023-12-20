using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting2 : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject reload;

    private float bulletForce = 15f;

    /*private void Start()
    {
        PlayerPrefs.SetInt("HealthP1", 100);
    }*/
    // Update is called once per frame
    int lastFingerId = -1;

    private void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.y > Screen.height / 2 && reload.transform.localScale.x >= .5f)
                    {
                        Shoot();
                        reload.transform.localScale = new Vector2(0, .02f);
                    }

                    lastFingerId = touch.fingerId;
                    break;

            }
        }
        /*
        if (Input.GetKey("w") && reload.transform.localScale.x >= .5f)
        {
            Shoot();
            reload.transform.localScale = new Vector2(0, .02f);
        }
        */

        if (reload.transform.localScale.x < .5f)
        {
            reload.transform.localScale = new Vector2(reload.transform.localScale.x + .01f, .05f);
        }



    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

}
