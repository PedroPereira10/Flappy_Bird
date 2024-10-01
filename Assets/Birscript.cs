using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birscript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public float flapStrenght;
    public LogicManagerScript logic;
    public bool birdIsAlive = true;
    public float MaxValue = 15;
    public AudioSource PressFly;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            MyRigidbody.velocity = Vector2.up * flapStrenght;
            PressFly.Play();
        }

        if (transform.position.y >= MaxValue)
            {
                logic.gameOver();
                birdIsAlive = false;
            }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
