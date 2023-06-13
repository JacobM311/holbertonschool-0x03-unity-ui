using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody rb;
    private int score = 0;
    private int health = 5;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (health == 0)
        { 
            Debug.Log("Game Over!");
            ReloadScene();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score += 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
        if (other.tag == "Trap")
        {
            health -= 1;
            Debug.Log("Health: " + health);
        }
    }

    public void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed);
        }
    }
}
