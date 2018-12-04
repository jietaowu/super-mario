using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public PlayerController thePlayer;

    public int coinCount;

    public Text coinText;

    public int healthCount;

    public int maxHealth;
    


    public Image heart1;  //image heart1
    public Image heart2;  //image heart2
    public Image heart3;  //image heart3


    //sprites represent the images
    public Sprite heartFull;
    public Sprite heartHalf;
    public Sprite heartEmpty;





    // Use this for initialization
    void Start () {

        thePlayer = FindObjectOfType<PlayerController>(); //find the player script

        healthCount = maxHealth;
    }

    // Update is called once per frame
    void Update () {
		
	}



    public void AddCoins(int coinsToAdd)
    {
        coinCount = coinCount + coinsToAdd;

        coinText.text = "Coins " + coinCount;

    }


    public void HurtPlayer(int damageToGive)
    {
        healthCount = healthCount - damageToGive;

        UpdateHeartMeter();  //update the heart
    }


    public void UpdateHeartMeter()
    {
        switch (healthCount)
        {
            case 6:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartFull;
                return;

            case 5:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartHalf;
                return;

            case 4:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartEmpty;
                return;

            case 3:
                heart1.sprite = heartFull;
                heart2.sprite = heartHalf;
                heart3.sprite = heartEmpty;
                return;

            case 2:
                heart1.sprite = heartFull;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                return;

            case 1:
                heart1.sprite = heartHalf;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                return;

            case 0:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                return;

            default:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                return;
        }
    }





}
