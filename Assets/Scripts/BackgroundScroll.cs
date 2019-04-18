using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed=0.05f;
    public GameObject endPosition;
    private GameObject cam;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        cam.transform.position = Vector3.Lerp(cam.transform.position, endPosition.transform.position, 0.0001f);
    }
}
