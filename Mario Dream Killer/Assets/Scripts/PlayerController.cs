using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D myRigidbody; //主角

    public LevelManager theLevelManager;

    public float activeMoveSpeed; //活跃移动速度

    public float jumpSpeed; //高度

    public bool larger ;

    public Transform thePlayer;

    public float scale = 10.0f;


    public Transform groundCheck;

    public float groundCheckRadius;

    public LayerMask whatIsGround;

    public bool isGrounded;

    public GameObject GameOverScreen;



    void Start()
    {

        myRigidbody = GetComponent<Rigidbody2D>(); //获取角色

        thePlayer = GetComponent<Transform>();

        theLevelManager = FindObjectOfType<LevelManager>();




    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidbody.velocity = new Vector3(activeMoveSpeed, myRigidbody.velocity.y, 0f);

            if (larger)
            {
                transform.localScale = new Vector3(5f, 5f, 5f); //改变角色面对的方向（右边）
            }
            else
            {

                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f); //改变角色面对的方向（右边）

            }

        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {

            if (larger)
            {
                myRigidbody.velocity = new Vector3(-activeMoveSpeed, myRigidbody.velocity.y, 0f);
                transform.localScale = new Vector3(-5f, 5f, 5f); //改变角色面对的方向（左边）
            }
            else
            {


                myRigidbody.velocity = new Vector3(-activeMoveSpeed, myRigidbody.velocity.y, 0f);
                transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f); //改变角色面对的方向（左边）
            }

        }
        else
        {
            myRigidbody.velocity = new Vector3(0f, myRigidbody.velocity.y, 0f);
        }

        if (Input.GetButtonDown("Jump") && isGrounded) //角色跳起和接触地面
        {
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jumpSpeed, 0f);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {



        if (other.tag == "jumpMachine")
        {

            jumpSpeed = 10.0f;

        }
        else
        {
            jumpSpeed = 6.0f;
        }


        if (other.tag == "mushroom")
        {

            larger = true;

           

        }

        if (other.tag == "KillPlane")
        {

            gameObject.SetActive(false);
            GameOverScreen.SetActive(true);


        }
        else
        {
            GameOverScreen.SetActive(false);
        }





    }


  



}



