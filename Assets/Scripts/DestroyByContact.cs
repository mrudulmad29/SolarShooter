using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour
{

    public GameController gameController;
    public int scoreValue;
    // public GameController1 gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        // if (gameController == null)
        // {
        //     Debug.Log("Cannot find 'GameController' script");
        // }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            //  SceneManager.LoadScene(5);
            Application.LoadLevel(7);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        //gameController.AddScore(scoreValue);


    }
}