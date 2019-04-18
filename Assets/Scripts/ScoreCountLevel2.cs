using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCountLevel2 : MonoBehaviour
{
    public int score = 0;

    public Text scoreText;
    // Start is called before the first frame update
    void Awake()
    {
        // scoreText = this.GetComponent<Text>();

    }

    public void Update()
    {

        scoreText.text = "Score:" + score.ToString();

        if (score >= 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        // Application.LoadLevel(4);
    }
}
