using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private 
    float moveSpeed = 5f;
    private Animator animator;
    private SpriteRenderer spriteRenderer;


    Vector2 movement;
    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool canRun = animator.GetCurrentAnimatorStateInfo(0).IsName("Attack") == false;
        if (canRun == false)
            return;

        Vector2 direction = new Vector2();
        direction.x = Input.GetAxisRaw("Horizontal");
        
        animator.SetBool("IsRun", direction.x != 0f);

        if (direction.x != 0f)
        {
            float flipX = direction.x < 0 ? -1f : 1f;
            float scaleX = flipX * Mathf.Abs(transform.localScale.x);

            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);

            transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
        }
    }
}
