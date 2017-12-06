using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject Asteroid;
    public Transform AsteroidContainer;

    float minDelay = 0.5f, maxDelay = 1f;

    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= Random.Range(minDelay, maxDelay))
        {
            timer = 0f;
            GameObject go = Instantiate(Asteroid, AsteroidContainer);
            go.transform.position = new Vector3(11f, Random.Range(-4.5f, 4.5f), 0f);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }

    }
}
