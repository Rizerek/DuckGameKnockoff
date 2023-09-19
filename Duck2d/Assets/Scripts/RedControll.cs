using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedControll : MonoBehaviour
{
    public GameObject Rock;
    private bool rock;
    public GameObject text;
    public GameObject Knock;
    public GameObject Hole;
    private bool gun2;
    private bool pistol;
    public GameObject Gun2;
    public GameObject Pistol;
    public bool crouch;
    public int hp;
    private bool facingRight = true;
    private Rigidbody2D rb2d;
    private  float speed;
    public float startSpeed;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadious;
    public LayerMask whatIsGround;
    public float moveInputx;
    private float moveInputt;
    public float jumpForce;
    public GameObject handGranade;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        speed = startSpeed;
        crouch = false;
        hp = 5;
    }

    // Update is called once per frame
   private void FixedUpdate()
    {
        if (Input.GetKey("f"))
        {
            hp = 5;
            transform.position = new Vector3(1, -8, 0);
        }
        Vector3 Scaler = transform.localScale;

        transform.localScale = Scaler;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);

        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            // if (Scaler.x < 0)
            // {
            //       Flip();
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //  }
        }
        else if (Input.GetKey("a"))
        {
            transform.position += Vector3.right * -speed * Time.deltaTime;
            // if (Scaler.x > 0)
            // {
            //     Flip();
            transform.rotation = Quaternion.Euler(0, -180, 0);
            // }
        }
        if (hp<=0)
        {
            Die();
        }
        if (Scaler.x > 0)
        {
            facingRight = true;
        }

        if (Scaler.x < 0)
        {
            facingRight = false;
        }
    }
    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        if (hp < 0)
        {
            Game();
            Debug.Log(speed);
            Die();
            
        }
    }
    void Update()
    {
 
        if (Input.GetKey("w"))
        {
            if (isGrounded == true&&crouch == false)
            {
                rb2d.velocity = Vector2.up * jumpForce;
            }

        }
        if (Input.GetKey("s"))
        {
            Debug.Log(hp);
            if (crouch == false)
            {
                Crouch();
                Debug.Log(crouch);
            }
            else if(crouch == true)
            {
                Debug.Log(speed);
                exitCrouch();
            }
            

        }

        if (Input.GetKey("f"))
        {
            exitCrouch();
        }


            // else if (moveInputx == -1 || moveInputx == 1)
            // {
            //     moveInputx = 0;
            // }
        }
    void Game()
    {
        text.SetActive(true);
        StartCoroutine(Spawn());
    }
    public IEnumerator Spawn()
    {


        yield return new WaitForSeconds(1f);
        text.SetActive(false);
    }
    void Crouch()
    {
        Debug.Log(checkRadious);
        Vector3 Scaler = transform.localScale;
        Scaler.y = 2;
        transform.localScale = Scaler;
        speed = 1;
        crouch = true;
    }
    void exitCrouch()
    {
        Vector3 Scaler = transform.localScale;
        Scaler.y = 5;
        transform.localScale = Scaler;
        speed = startSpeed;
        crouch = false;
    }
    void Flip()
    {

        
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        
    }
    void Die()
    {
        gameObject.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Walls")
        {
            text.SetActive(true);
            gameObject.SetActive(false);
        }
        if (col.gameObject.layer == 9)
        {
            Hole.SetActive(true);
            handGranade.SetActive(false);
            Knock.SetActive(false);
        }
        if (col.gameObject.layer == 10)
        {
            handGranade.SetActive(true);
            Hole.SetActive(false);
            Knock.SetActive(false);
        }
        if (col.gameObject.layer == 13)
        {
            Gun2.SetActive(false);
            Gun2.SetActive(true);
            gun2 = true;
            if (gun2 == true)
            {
                Pistol.SetActive(false);
                Rock.SetActive(false);
            }
        }
        if (col.gameObject.layer == 15)
        {
            Rock.SetActive(false);
            Rock.SetActive(true);
            rock = true;
            if (rock== true)
            {
                Pistol.SetActive(false);
                Gun2.SetActive(false);

            }
        }
        if (col.gameObject.layer == 12)
        {
            Pistol.SetActive(false);
            Pistol.SetActive(true);
            pistol = true;
            if (pistol == true)
            {
                Gun2.SetActive(false);
                Rock.SetActive(false);
            }
        }
        if (col.gameObject.layer == 14)
        {
            Knock.SetActive(true);
            handGranade.SetActive(false);
            Hole.SetActive(false);




        }
        if (col.gameObject.layer == 16)
        {
            text.SetActive(true);
            gameObject.SetActive(false);
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {

    }
   // void OnGUI()
   // {
   //     Event x = Event.current;
   //     if (x.control)
   //     {
   //         Debug.Log("Control was pressed.");
    //    }
   //     Event e = Event.current;
   //     if (e.alt)
   //     {
   //         if (Application.platform == RuntimePlatform.OSXEditor)
   //         {
   //             Debug.Log("Option key was pressed");
  //          }
   //         else if (Application.platform == RuntimePlatform.WindowsEditor)
   //         {
    //            Debug.Log("Alt Key was pressed!");
    //        }
    //    }
   // }
}
