using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public GameObject ExplosionPlayer;
    public GameObject ExplosionAsteroid;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Laser")
        {
            Destroy(collision.gameObject);
            Instantiate(ExplosionAsteroid, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (collision.tag == "Player")
        {
            Instantiate(ExplosionPlayer, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
