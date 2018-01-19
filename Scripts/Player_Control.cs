//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Player_Control : MonoBehaviour
//{
//    //Déclaration des variables
//    public int playerSpeed = 10;
//    public int playerJumpPower = 1250;
//    public float moveX;
//    public bool isGrounded;
//    public float DistanceBottomTopPlayer = 0.9f;

//    public float Speed = 0;
//    public float MaxSpeed = 5;
//    public float Acceleration = 10;
//    public float Deceleration = 10;
//    public Vector3 position;
    
//    public AudioClip audioMort1;
//    public AudioClip audioPas;
//    public AudioClip audioSaut;
//    public AudioClip audioAtterrissage;
//    public AudioClip audioErreurHack;
//    public AudioClip audioSuccesHack;
//    public AudioClip audioSortOrdi;
//    public AudioClip audioRangeOrdi;
//    public AudioClip audioTouchesOrdi;
//    public AudioClip audioVoix;

//    private Animator anim;
//    AudioSource audioSource;
//    private bool Atterri = false;
//    private float scaleSpeed;

//    // Use this for initialization
//    void Start()
//    {
//        anim = GetComponent<Animator>();
//        position = transform.position;
//    }

//    // Update is called once per frame
//    void FixedUpdate()
//    {
//        PlayerRayCast();
//        PlayerMove();

//    }

//    void PlayerMove()
//    {
//        moveX = Input.GetAxis("Horizontal");

//        //scaleSpeed = Speed / MaxSpeed;
//        //anim.speed = scaleSpeed;

//        if (Input.GetButtonDown("Jump") && isGrounded)
//            Jump();

//        if (moveX != 0)
//        {
            
//            anim.SetBool("IsWalking", true);
//            if (isGrounded && !Atterri)
//            {
//                SoundManager.instance.EffetSonore(audioPas);
//            }
//        }
//        else
//        {
//            anim.SetBool("IsWalking", false);
//        }

//        if ((Input.GetKey("left")) && (Speed > -MaxSpeed))
//        {
//            Speed = Speed - Acceleration * Time.deltaTime;
//            GetComponent<SpriteRenderer>().flipX = true;
//        }
//        else if ((Input.GetKey("right")) && (Speed < MaxSpeed))
//        {
//            GetComponent<SpriteRenderer>().flipX = false;
//            Speed = Speed + Acceleration * Time.deltaTime;
//        }
//        else
//        {
//            if (Speed > Deceleration * Time.deltaTime)
//                Speed = Speed - Deceleration * Time.deltaTime;
//            else if (Speed < -Deceleration * Time.deltaTime)
//                Speed = Speed + Deceleration * Time.deltaTime;
//            else Speed = 0;
//        }

//        position.x = transform.position.x + Speed * Time.deltaTime;
//        position.y = transform.position.y;
//        position.z = transform.position.z;
//        transform.position = position;
//    }

//    void Jump()
//    {
//        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
//        SoundManager.instance.EffetSonore(audioSaut);
//        isGrounded = false;
//        Atterri = true;
//        //anim.Play("jump_final");
//        anim.SetBool("IsJumping", true);
//    }

//    void PlayerRayCast()
//    {
//        RaycastHit2D rayDown = Physics2D.Raycast(transform.position, Vector2.down);

//        if (rayDown.distance < DistanceBottomTopPlayer)
//        {
//            anim.SetBool("IsFalling", false);
//            if (Atterri)
//            {
//                SoundManager.instance.EffetSonore(audioAtterrissage);
//                Atterri = false;
//            }
//            isGrounded = true;
//        }
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        Debug.Log("collision");
//        if (collision.tag == "Indice")
//        {
//            SoundManager.instance.EffetSonore(audioVoix);
//            while (audioSource.isPlaying)
//            {
//                //Pour assurer la fin de la trame sonore
//            }
//        }
//        if(collision.tag == "laser")
//        {
//            Debug.Log("laser");
//            Destroy(collision.gameObject);
//            Application.LoadLevel(Application.loadedLevel);
//        }
//    }
//}
