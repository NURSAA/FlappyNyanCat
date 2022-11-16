using UnityEngine;
using UnityEngine.UI;

public class ManagerGame : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public Text createdBy;
    public Text university;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;

    //pause game when start to hit the play button
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        //reset statistics
        score = 0;
        scoreText.text = score.ToString();

        //disable UI elements
        playButton.SetActive(false);
        gameOver.SetActive(false);
        createdBy.gameObject.SetActive(false);
        university.gameObject.SetActive(false);

        //start actuall game
        Time.timeScale = 1f;
        player.enabled = true;

        //destroy pipes
        PipesMovement[] pipes = FindObjectsOfType<PipesMovement>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }

    //freze game
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    
    //end game on colision with pipe
    public void EndGame()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        createdBy.gameObject.SetActive(true);
        university.gameObject.SetActive(true);

        Pause();
    }

    //add point after each pipe
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
