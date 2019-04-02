using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    private Text scoreText;
    // Start is called before the first frame update
      void Awake()
    {
        scoreText = this.GetComponent<Text>();
        
    }

   public void UpdateUI(int qty, int maxItemsInLevel)
   {
       

       scoreText.text = qty + "/" + maxItemsInLevel;
   } 
}
