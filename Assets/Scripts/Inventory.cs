using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject explosion;

    // private GameController1 gCont;

    void Start()
    {
        //   gCont = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController1>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if 'other' is a tagged an item
        // if(other.CompareTag("enemy"))
        // {
        //     // Pick up the item
        //    // cherryCounter++;
        //    gCont.PickUpItem();            // Instantiate the item feedback object
        //     Instantiate(explosion, other.transform.position, other.transform.rotation);
        //     Destroy(other.gameObject);
        // }
    }
}
