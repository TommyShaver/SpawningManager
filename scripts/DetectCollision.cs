using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DetectCollision : MonoBehaviour
{
    private GameManager gameManager;
    private int hits;
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    //This function is how to do something after a collision has been detcted when a box collider has trigger enabled. 
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
        
                Destroy(other.gameObject);
            
            
        }
        else if (other.CompareTag("Pizza"))
        {
            Destroy(other.gameObject);
            gameManager.AddScore(5);
        }
       
    }
}
