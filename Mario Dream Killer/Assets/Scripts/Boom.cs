using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject wall5;
    public GameObject wall6;
    public GameObject wall7;
    public GameObject wall8;

    public GameObject boom;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            boom.gameObject.SetActive(false);
            wall1.gameObject.SetActive(false);
            wall2.gameObject.SetActive(false);
            wall3.gameObject.SetActive(false);
            wall4.gameObject.SetActive(false);
            wall5.gameObject.SetActive(false);
            wall6.gameObject.SetActive(false);
            wall7.gameObject.SetActive(false);
            wall8.gameObject.SetActive(false);
           

        }

    }

}
