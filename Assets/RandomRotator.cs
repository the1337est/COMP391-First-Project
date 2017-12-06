using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{

    Rigidbody2D rb;
    public float Tumble;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.value * Tumble;
	}

}
