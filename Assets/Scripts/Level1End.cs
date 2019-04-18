using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1End : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextLevel(5.0f));
    }

    private IEnumerator LoadNextLevel(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Application.LoadLevel(3);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score.ToString();

        if (score >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
