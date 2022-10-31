using UnityEngine;

public class MoveMob : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float MoveSpeed = 3f;

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);

    }
}
