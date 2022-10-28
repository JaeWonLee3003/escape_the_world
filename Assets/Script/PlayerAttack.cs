using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool attacking = false;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        attackArea = transform.GetChild(0).gameObject;

        // �ִϸ��̼� �������� �̺�Ʈ �߰�
        for (int i = 0; i < animator.runtimeAnimatorController.animationClips.Length; i++)
        {
            AnimationClip clip = animator.runtimeAnimatorController.animationClips[i];

            AnimationEvent animationEvent = new AnimationEvent();
            animationEvent.time = clip.length; // ������ �� �Ǵ�. ������ 0, ���� length (0 ~ length)
            animationEvent.functionName = "AnimationComplete";
            animationEvent.stringParameter = clip.name;

            clip.AddEvent(animationEvent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool attacking = animator.GetBool("IsAttack");

        if (Input.GetKeyDown(KeyCode.E) && attacking == false)
        {
            Attack();
        }
    }

    void AnimationComplete(string name)
    {
        if (name.Contains("Attack"))
        {
            EndAttack();
        }
    }

    private void Attack()
    {
        attackArea.SetActive(true);
        animator.SetBool("IsAttack", true);
    }

    private void EndAttack()
    {
        attackArea.SetActive(false);
        animator.SetBool("IsAttack", false);
    }
}
