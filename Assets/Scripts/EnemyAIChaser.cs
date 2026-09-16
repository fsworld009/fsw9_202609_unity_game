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

    private CharacterMove cm;
    private Animator animator;
    private CharacterHealth ch;
    void OnEnable()
    {
        player = GameObject.FindWithTag("Player");
        timerMove = moveTime;
        timerCooldown = 0;
        cm = GetComponent<CharacterMove>();
        ch = GetComponent<CharacterHealth>();
        animator = GetComponentInChildren<Animator>();
        animator.SetBool("IsRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (ch.IsDead()) return;
        cm.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z), 0);
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
                    cm.Move(Vector3.forward);
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
