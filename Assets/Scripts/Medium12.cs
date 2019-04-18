﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medium12 : MonoBehaviour
{
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

    }
}
