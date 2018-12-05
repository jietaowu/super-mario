using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBox : MonoBehaviour
{

    private Rigidbody2D playerRigidbody;

    //public GameObject wall;

    public AudioSource crateHit;

    public PlayerController thePlayer;


    public LevelManager theLevelManager;

    public int scoreValue;


    // Use this for initialization
    void Start()
    {



        playerRigidbody = GetComponent<Rigidbody2D>();

        thePlayer = FindObjectOfType<PlayerController>(); //find the player script

        theLevelManager = FindObjectOfType<LevelManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        //if (other.tag == "box")
        //{
        //    crateHit.Play();
        //    other.gameObject.SetActive(false);


        //}

        if (other.tag == "bug")
        {
            crateHit.Play();
            other.gameObject.SetActive(false);
            theLevelManager.AddScores(scoreValue);


        }

        if (other.tag == "puff")
        {
            crateHit.Play();
            other.gameObject.SetActive(false);
            theLevelManager.AddScores(scoreValue);



        }

        //if (other.tag == "boom")
        //{
        //    crateHit.Play();
        //    other.gameObject.SetActive(false);
        //    wall.gameObject.SetActive(false);

        //}

        if (other.tag == "mushroom")
        {

            other.gameObject.SetActive(false);

        }




        //}


    }



}
