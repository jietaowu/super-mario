using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D myRigidbody; //主角

    public float activeMoveSpeed; //活跃移动速度

    public float jumpSpeed; //高度

    public bool larger ;

    public Transform thePlayer;

    public float scale = 10.0f;

    float timeLeft = 15.0f;


    void Start()
    {

        myRigidbody = GetComponent<Rigidbody2D>(); //获取角色

        thePlayer = GetComponent<Transform>();

       
    }

    // Update is called once per frame
    void Update()
    {
       


        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidbody.velocity = new Vector3(activeMoveSpeed, myRigidbody.velocity.y, 0f);

            if (larger)
            {
                transform.localScale = new Vector3(2f, 2f, 2f); //改变角色面对的方向（右边）
            }
            else
            {

                transform.localScale = new Vector3(1f, 1f, 1f); //改变角色面对的方向（右边）

            }

        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {

            if (larger)
            {
                myRigidbody.velocity = new Vector3(-activeMoveSpeed, myRigidbody.velocity.y, 0f);
                transform.localScale = new Vector3(-2f, 2f, 2f); //改变角色面对的方向（左边）
            }
            else
            {


                myRigidbody.velocity = new Vector3(-activeMoveSpeed, myRigidbody.velocity.y, 0f);
                transform.localScale = new Vector3(-1f, 1f, 1f); //改变角色面对的方向（左边）
            }

        }
        else
        {
            myRigidbody.velocity = new Vector3(0f, myRigidbody.velocity.y, 0f);
        }

        if (Input.GetButtonDown("Jump")) //角色跳起和接触地面
        {
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jumpSpeed, 0f);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {



        if (other.tag == "jumpMachine")
        {

            jumpSpeed = 20.0f;

        }
        else
        {
            jumpSpeed = 5.0f;
        }


        if (other.tag == "mushroom")
        {

            larger = true;

            //UpdCountDown();



        }


    }

    //private void UpdCountDown()
    //{
    //    if (timeLeft > 0)
    //    {
    //        timeLeft -= Time.deltaTime;


    //    }
    //    else
    //    {
    //        larger = false;
    //    }
    //}




}



