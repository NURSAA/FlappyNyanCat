using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRender;
    private int spriteIndex;
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;


    private void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

        //input bind to Space & mouse click
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }

        //update height of the cat
        direction.y += gravity * Time.deltaTime;

        //update position of the cat
        transform.position += direction * Time.deltaTime;
    }

    //reset player position
    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle"){
            FindObjectOfType<ManagerGame>().EndGame();
        }
        else if (other.gameObject.tag == "Scoring"){
            FindObjectOfType<ManagerGame>().AddScore();
        }
    }
}
