using Unity.VisualScripting;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private GameObject player;
    private float moveTimer;
    private float cooldownTimer;

    [SerializeField] private float maxMoveTime = 3;
    [SerializeField] private float maxCooldownTime = 1;
    [SerializeField] private float moveSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float stopDistance = 1.5f;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        moveTimer = maxMoveTime;
        cooldownTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer <= 0)
            {
                moveTimer = maxMoveTime;
            }
        }
        else
        {
            if (moveTimer > 0)
            {
                float distance = Vector3.Distance(player.transform.position, transform.position);
                if (distance > stopDistance) {
                    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                }
                moveTimer -= Time.deltaTime;
            }
            else
            {
                cooldownTimer = maxCooldownTime;
            }
        }
    }
}
