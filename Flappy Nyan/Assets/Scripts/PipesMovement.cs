using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    public float speed = 4.5f;
    private float leftBorderOfScreen;

    //get left border cordinates of the screen
    private void Start()
    {
        leftBorderOfScreen = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }

    //change position of the pipes
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        //destroy pipes when they are out of left border of screen
        if (transform.position.x < leftBorderOfScreen)
        {
            Destroy(gameObject);
        }
    }
}
