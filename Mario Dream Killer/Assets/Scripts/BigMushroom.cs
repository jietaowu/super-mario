using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BigMushroom : MonoBehaviour {

    //public Rigidbody2D myRigidbody; //主角

    //public PlayerController thePlayer;

    //public GameObject thePlayer;
    public bool bigger = false;


    public Transform thePlayer;

    public float scale = 2.0f;


    // Use this for initialization
    void Start() {


        thePlayer = GetComponent<Transform>();
        //myRigidbody = GetComponent<Rigidbody2D>(); //获取角色
        //thePlayer = FindObjectOfType<PlayerController>();

    }

    // Update is called once per frame
    void Update() {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        bigger = true;
        if (bigger)
        {
            other.transform.localScale += new Vector3(scale, scale, scale);

        }


    }



     




}
