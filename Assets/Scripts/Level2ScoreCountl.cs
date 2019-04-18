using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2ScoreCountl : MonoBehaviour
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

        if (score >= 5)
            Application.LoadLevel(2);
    }
}
