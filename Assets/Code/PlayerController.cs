using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    public float Speed;

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

        tempPos.x = Mathf.Clamp(tempPos.x, -8f, 8f);
        tempPos.y = Mathf.Clamp(tempPos.y, -4.5f, 4.5f);

        rb.position = tempPos;
    }
}
 