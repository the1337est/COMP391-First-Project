using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    public float Speed;

    public Vector2 Min, Max;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
	void FixedUpdate ()
    {

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 tempPos = rb.position;

        tempPos +=  Vector2.up * vertical * Time.deltaTime * Speed;
        tempPos += Vector2.right * horizontal * Time.deltaTime * Speed;
        tempPos.x = Mathf.Clamp(tempPos.x, Min.x, Max.x);
        tempPos.y = Mathf.Clamp(tempPos.y, Min.y, Max.y);

        rb.position = tempPos;
    }
}
 