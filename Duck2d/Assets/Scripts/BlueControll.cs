using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueControll : MonoBehaviour
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
    public float startSpeed;
    public int hp;
    public bool facingRightt = true;
    private Rigidbody2D rb2d;
    public float speed;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadious;
    public LayerMask whatIsGround;
    public GameObject handGranade;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        speed = startSpeed;
        crouch = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 Scaler = transform.localScale;

        transform.localScale = Scaler;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);

        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
           // if (transform.rotation == Quaternion.Euler(0, -180, 0))
           // {
                //Flip();
                transform.rotation = Quaternion.Euler(0, 0, 0);
           // }
        }
        else if (Input.GetKey("left"))
        {
            transform.position += Vector3.right * -speed * Time.deltaTime;
           // if (transform.rotation == Quaternion.Euler(0, 0, 0))
           // {
                // Flip();
                transform.rotation = Quaternion.Euler(0, -180, 0);

          //  }

        }

        //Debug.Log(moveInput);

        if (Scaler.x > 0)
        {
            facingRightt = true;
        }
        else if (Scaler.x < 0 )
        {
            facingRightt = false;
        }
        if (Input.GetKey("f"))
        {
            hp = 5;
            transform.position = new Vector3(3, -8,0);
        }

    }
    public void TakeDamage (int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            Die();
            Game();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isGrounded == true&&crouch==false)
            {
                rb2d.velocity = Vector2.up * jumpForce;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            if (crouch == false)
            {
                Crouch();
                
            }
            else if (crouch == true)
            {
                
                exitCrouch();
            }


        }
        if (Input.GetKey("f"))
        {
            exitCrouch();
        }
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
            if (gun2== true)
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
            if (rock == true)
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
    }   void Flip()
    {
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    
    void OnCollisionExit2D(Collision2D collision)
    {
 
    }
}
