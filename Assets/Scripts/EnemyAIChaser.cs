using Unity.VisualScripting;
using UnityEngine;

public class EnemyAIChaser : MonoBehaviour
{
    private GameObject player;
    private float timerMove;
    private float timerCooldown;

    [SerializeField] private float moveTime = 3;
    [SerializeField] private float cooldownTime = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float stopDistance = 1.5f;

    private CharacterMove ch;
    private Animator animator;
    void OnEnable()
    {
        player = GameObject.FindWithTag("Player");
        timerMove = moveTime;
        timerCooldown = 0;
        ch = GetComponent<CharacterMove>();
        animator = GetComponentInChildren<Animator>();
        animator.SetBool("IsRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        ch.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z), 0);
        if (timerCooldown > 0)
        {
            timerCooldown -= Time.deltaTime;
            if (timerCooldown <= 0)
            {
                timerMove = moveTime;
                animator.SetBool("IsRunning", true);
            }
        }
        else
        {
            if (timerMove > 0)
            {
                float distance = Vector3.Distance(player.transform.position, transform.position);
                if (distance > stopDistance) {
                    ch.Move(Vector3.forward);
                }
                timerMove -= Time.deltaTime;
            }
            else
            {
                timerCooldown = cooldownTime;
                animator.SetBool("IsRunning", false);
            }
        }
    }
}
