using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMovement : MonoBehaviour
{
    public bool isDead;
    Animator anim;

    Touch touch;
    float speedModifier;

    float oldY;


    private void Start()
    {
        speedModifier = 0.002f;
       
        anim = GetComponent<Animator>();

        oldY = transform.position.y;
        
        DontDestroyOnLoad(gameObject);
    }

 




    /*

    //Animasyon

    private void myanimation()
    {
        float currentY = transform.position.y;

        if (lastY > currentY)
        {
            anim.SetTrigger("up");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("down");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("left");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger("right");
        }

        lastY = currentY;
    }
    */






    void Update()
    {

        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y + touch.deltaPosition.y * speedModifier,
                    transform.position.z);
            }

        }







        if (Input.touchCount > 0)
        {

            if (1==1)
            {
                if (transform.position.y > oldY)
                {
                    anim.SetBool("up", true);
                    oldY = transform.position.y;
                }

                if (transform.position.y < oldY)
                {
                   // anim.SetTrigger("down");
                   //oldY = transform.position.y;
                }

                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                   // anim.SetTrigger("left");
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                   // anim.SetTrigger("right");
                }
            }
        }
        















        /*
        //YÖN TUÞLARI HAREKETÝ
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float yyonu = 10;
            yyonu *= Time.deltaTime;
            transform.Translate(0, yyonu, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            float yyonu = (-1)*10;
            yyonu *= Time.deltaTime;
            transform.Translate(0, yyonu, 0, Space.World);
        }

        float xyonu = Input.GetAxis("Horizontal") * 15;
        xyonu *= Time.deltaTime;
        transform.Translate(xyonu, 0, 0, Space.World);
        */








        //SINIRLAMA


        if (transform.position.x < -1.2f)
            transform.position = new Vector3(-1.2f, transform.position.y, transform.position.z);

        else if (transform.position.x > 1.2f)
            transform.position = new Vector3(1.2f, transform.position.y, transform.position.z);

        else if (transform.position.y < -1.7f)
            transform.position = new Vector3(transform.position.x, -1.7f, transform.position.z);

        else if (transform.position.y > 3.5f)
            transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);

        //   transform.position.x = -4f; XXXXX   BAÞARISIZ    XXXXXX
       

    }



   


}
