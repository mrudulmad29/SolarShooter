using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextLevel(17.5f));
    }

    private IEnumerator LoadNextLevel(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Application.LoadLevel(7);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
