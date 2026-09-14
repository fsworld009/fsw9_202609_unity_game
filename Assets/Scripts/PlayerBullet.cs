using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    //private Vector3 forward;
    //private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVelocity(Vector3 shootPointForward)
    {

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.linearVelocity = shootPointForward * speed;
    }

    private void OnTriggerEnter(Collider collider)
    {
        switch (collider.tag)
        {
            case "Enemy":
                // EnemyはColliderとTrigger持つ、そのうちのColliderしか反応しないように
                if (collider.isTrigger) return;
                CharacterHealth eh = collider.gameObject.GetComponent<CharacterHealth>();
                if (eh != null)
                {
                    eh.Damage();
                }
                Destroy(gameObject);
                break;
            case "Terrain":
                Destroy(gameObject);
                break;
            default:
                break;
        }
        
    }
}
