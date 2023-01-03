using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float turnspeed;
    public float jumpforce;
    private CharacterController controller;
    private Vector3 moveDicretion;
    public float GravityScale;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //moveDicretion = new Vector3(Input.GetAxis("Horizontal") * turnspeed,moveDicretion.y, Input.GetAxis("Vertical")*speed);
        float ystore = moveDicretion.y;
        moveDicretion = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        moveDicretion = moveDicretion.normalized * speed;
        moveDicretion.y = ystore;
        
        if (controller.isGrounded)
        {
            moveDicretion.y = 0;
            if (Input.GetButtonDown("Jump"))
            {
                moveDicretion.y = jumpforce;
            }
        }
        controller.Move(moveDicretion * Time.deltaTime);
        moveDicretion.y = moveDicretion.y + (Physics.gravity.y * GravityScale * Time.deltaTime);
    }

    /*public float movespeed;
    public float jumpforce;
    public float LeftRightspeed;
    private Vector3 moveDicretion;
    public float GravityScale;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void LateUpdate()
    {
        moveDicretion.z = movespeed;
       // transform.Translate(Vector3.forward * Time.deltaTime * movespeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < 570f)
            {
                transform.Translate(Vector3.left * Time.deltaTime * LeftRightspeed * -1);
            }
        }
    }*/
    
    /*public float moveSpeed = 5;
    public float leftRightSpeed;

    Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody rb;

    public GameObject runAnim;
    public GameObject jumpAnim;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("terrain"))
        {
            isGrounded = true;
            runAnim.SetActive(true);
            jumpAnim.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        //Move left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //if(this.gameObject.transform.position.x > -4.6f)
            //{
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            //}
        }
        //Move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //if (this.gameObject.transform.position.x < 4.6f)
            //{
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * (-1));
            //}
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);

            runAnim.SetActive(false);
            jumpAnim.SetActive(true);
            isGrounded = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CoinSpeed")
        {
            moveSpeed = 15;
            StartCoroutine(timeSpeed());
            other.gameObject.SetActive(false);
        }
    }
    IEnumerator timeSpeed()
    {
        yield return new WaitForSeconds(0.6f);
        moveSpeed = 5;
    }*/
}
