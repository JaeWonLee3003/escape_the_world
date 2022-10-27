using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

     float moveSpeed = 5f;
    private Animator animator;


    public Rigidbody2D rb;


    Vector2 movement;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2();
        direction.x = Input.GetAxisRaw("Horizontal");

       
      
            animator.SetBool("IsRun", direction.x < +1);

            transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
       
    }
}
