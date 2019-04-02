using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController1 : MonoBehaviour
{
    public ScoreCount scoreCounter;
   // public GameObject ui_EndLevelPanel;

    private int itemCounter = 0; //how may items picked
    private int totalItemCount = 0; //how many items in level


    // Start is called before the first frame update
    void Start()
    {
        
        totalItemCount = GameObject.FindGameObjectsWithTag("enemy").Length;
       // Debug.Log(totalItemCount);

       scoreCounter.UpdateUI(itemCounter, totalItemCount);
    }

    // Update is called once per frame
    
    //called when an item is picked up
    public void PickUpItem()
    {
        scoreCounter.UpdateUI(++itemCounter, totalItemCount);
    }

    // public void LevelEnd()
    // {
    //     ui_EndLevelPanel.SetActive(true);
    //     ui_EndLevelPanel.GetComponentInChildren<UI_CherryCounter>().UpdateUI(itemCounter, totalItemCount);
    // }
}
