using UnityEngine;

public class Enemy : MonoBehaviour
{
    private
float moveSpeed = 3f;
    private Animator animator;
    private SpriteRenderer spriteRenderer;


    Vector2 movement;
    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }



    void Update()
    {

        




        if (Hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public int Hp = 20;
    public void TakeDamage(int damage)
    {
        Hp = Hp - damage;
    }
}
