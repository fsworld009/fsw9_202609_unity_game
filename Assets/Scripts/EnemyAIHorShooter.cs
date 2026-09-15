using UnityEngine;


public class EnemyAIHorShooter : MonoBehaviour
{
    [SerializeField] private float distanceBeforeTurn = 5f;
    [SerializeField] private float firstShootWaitTime = 1f;

    [SerializeField] private bool moveLeftAtStart;

    private float firstShootTimer;
    private bool moveLeft;

    private float movedDistance;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
        firstShootTimer = firstShootWaitTime;
        moveLeft = moveLeftAtStart;
        movedDistance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (firstShootTimer > 0)
        {
            firstShootTimer -= Time.deltaTime;
        } else
        {
            GetComponent<CharacterShoot>().Shoot();
        }

        CharacterMove cm = GetComponent<CharacterMove>();
        Vector3 moveDir = moveLeft ? Vector3.left : Vector3.right;
        cm.Move(moveDir);

        // count moved distance regardless of actually moved or not
        movedDistance += cm.GetMoveSpeed() * Time.deltaTime;
        if (movedDistance >= distanceBeforeTurn)
        {
            moveLeft = !moveLeft;
            movedDistance = 0;
        }
    }
}
