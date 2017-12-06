using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Left = -1,
    Right = 1
}

public class Movable : MonoBehaviour
{
    public Direction MoveDirection;
    public float Speed = 10f;
	
	void Update ()
    {
        transform.position += Vector3.right * Time.deltaTime * Speed * (int)MoveDirection;
	}
}
