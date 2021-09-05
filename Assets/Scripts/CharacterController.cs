using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameManager gameManager;

    Rigidbody rb;
    Animator anim;

    float velocity = 8.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = this.gameObject.GetComponent<Animator>();

    }

    void Update()
    {

        if (gameManager.isActive)
        {
            bool isDown = Input.GetMouseButton(0);
            if (isDown != false)
            {
                anim.SetBool("run", true);
                transform.Translate(0, 0, velocity * Time.deltaTime);
            }
            else
            {
                anim.SetBool("run", false);
            }
        }



        //if (Input.GetMouseButton(0))
        //{
        //    transform.Translate(0, 0, velocity * Time.deltaTime);
        //}

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            gameManager.isActive = false;
        }
    }

}
