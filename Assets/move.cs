using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpForce = 2;
    [SerializeField]
    private Animator animator; // Corrected typo from Animattion to Animator

    void Start()
    {
        // Any initialization if needed
    }

    public float moveSpeed = 5f; // Movement speed

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime;
        gameObject.transform.position += movement;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 1);
        }

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    gameObject.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    gameObject.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        //}

        //if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
        //{
        //    gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        //    gameObject.transform.position += new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
        //{
        //    gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 1);
        //    gameObject.transform.position += new Vector3(-speed * Time.deltaTime, speed * Time.deltaTime, 0);
        //}
        //if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
        //{
        //    gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        //    gameObject.transform.position += new Vector3(speed * Time.deltaTime, -speed * Time.deltaTime, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
        //{
        //    gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 1);
        //    gameObject.transform.position += new Vector3(-speed * Time.deltaTime, -speed * Time.deltaTime, 0);
        //}

        // Set the "run" parameter in the animator based on horizontal movement
        bool isRunning = Mathf.Abs(Input.GetAxis("Horizontal")) > 0;
        animator.SetBool("run", isRunning);
    }

    // Uncomment and implement this if you have collision logic for jumping or other interactions
    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Wall"))
    //     {
    //         Vector3 reverseForce = -rb.velocity;
    //         rb.AddForce(reverseForce, ForceMode.Impulse);
    //     }
    // }
}
