using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float fuerzaSalto = 5f;
    public bool touchFloor;
    public bool alive;

    [SerializeField] GameOverScreen deathMenu;
    [Header("Animation")]
    private Animator animator;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Space) && touchFloor)
        {
            playerRB.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            touchFloor = false;
        }

        animator.SetFloat("y", playerRB.velocity.y);
    }

    private void FixedUpdate()
    {
        animator.SetBool("onFloor", touchFloor);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Floor")
        {
            touchFloor = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            alive = false;
            animator.SetBool("alive", alive);
            deathMenu.ActiveScreenLose();
        }

    }
}
