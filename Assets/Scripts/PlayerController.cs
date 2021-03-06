﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public float speed = 10.0f;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Private Variables
    private Rigidbody2D rBody;

    public Text LivesUIText;
    const int MaxLives=3;
    int lives;
    public void Init()
    {
        lives= MaxLives;
        LivesUIText.text= lives.ToString();
        transform.position = new Vector2 (0,0);
        gameObject.SetActive (true);
            }
     
    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // Instantiate
    }

    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        // Debug.Log("H: " + horiz + " , V: " + vert);
        Vector2 newVelocity = new Vector2(horiz, vert);

        rBody.velocity = newVelocity * speed;

        // Restrict the player from leaving the play area
        rBody.position = new Vector2(
            Mathf.Clamp(rBody.position.x, minX, maxX),   // Restrict x position to -8 and 4
            Mathf.Clamp(rBody.position.y, minY, maxY));  // Restrict y position to -4 and 4
    }
}
