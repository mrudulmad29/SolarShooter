using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    public int score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
      //  Debug.Log(other.tag);

      //check if 'other' is a tagged an item
      if(other.gameObject.tag.Equals ("enemy"))
      {
          //pick up item
          score++;
       //  Debug.Log("num of cherries couted:"+score);
         Destroy(other.gameObject);
        // ScoreScript.scoreValue += 10;
      }
    }
}