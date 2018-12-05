using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {

    public LevelManager theLevelManager;

    public int scoreValue;
    // Use this for initialization
    void Start () {

        theLevelManager = FindObjectOfType<LevelManager>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

            theLevelManager.AddScores(scoreValue);

        }

       


    }



}
