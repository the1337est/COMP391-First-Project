using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    public float Speed;
    public float FireInterval = 0.25f;

    float timer = 0f;

    public Vector2 Min, Max;

    public GameObject LaserPrefab;

    public Transform SpawnPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1"))
        {
            if (timer >= FireInterval)
            {
                timer = 0f;
                Instantiate(LaserPrefab, SpawnPoint.position, LaserPrefab.transform.rotation);
            }
        }

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
 