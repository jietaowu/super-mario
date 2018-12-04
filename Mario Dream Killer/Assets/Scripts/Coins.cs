using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

    public AudioSource coinSound;

    public LevelManager theLevelManager;

    public int coinValue;

	// Use this for initialization
	void Start () {

        theLevelManager = FindObjectOfType<LevelManager>();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            coinSound.Play();

            theLevelManager.AddCoins(coinValue);

            gameObject.SetActive(false);

        }


    }



}
