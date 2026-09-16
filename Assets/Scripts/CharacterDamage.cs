using UnityEngine;

public class CharacterDamage : MonoBehaviour
{
    // 一旦強制的にfalseにする
    [SerializeField] private bool hasKnockBack;
    [SerializeField] private float invisibleTime;

    private float timerInvisible;

    private bool isInvisible;
    private bool isKnockback;

    private Animator animator;
    private CharacterHealth ch;

    void OnEnable()
    {
        // Knockback設計の問題あり、一旦使わない
        hasKnockBack = false;


        timerInvisible = 0;
        isKnockback = false;

        ch = GetComponent<CharacterHealth>();
        animator = GetComponentInChildren<Animator>();

        animator.SetBool("IsKnockback", false);
        isInvisible = false;
        animator.SetBool("IsInvisible", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerInvisible > 0)
        {
            timerInvisible -= Time.deltaTime;
            if (timerInvisible <= 0)
            {
                isInvisible = false;
                animator.SetBool("IsInvisible", false);
            }
        }
    }

    // キャラクターがダメージを受けた時この関数を呼ぶ
    public void ReceiveDamage(float damage)
    {
        if (damage <= 0 || ch.IsDead()) return;
        if (isInvisible || isKnockback) return;

        ch.Damage((int)damage);

        // TODO: 死亡アニメーション処理？
        if (ch.IsDead()) return;

        if (hasKnockBack)
        {
            // Set flag and play knockback animation
            isKnockback = true;
            animator.SetBool("IsKnockback", true);
        } else
        {
            SetInvisible();
        }

    }


    private void SetInvisible()
    {
        isInvisible = true;
        animator.SetBool("IsInvisible", true);
        timerInvisible = invisibleTime;
    }

    public void OnKnockBackAnimationEnd()
    {
        isKnockback = false;
        animator.SetBool("IsKnockback", false);
        SetInvisible();
    }
}
