using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        switch (collider.tag)
        {
            case "Enemy":
                // EnemyはColliderとTrigger持つ、そのうちのColliderしか反応しないように
                if (collider.isTrigger) return;
                Destroy(gameObject);
                break;
            case "Terrain": case "EnemyBullet":
                Destroy(gameObject);
                break;
            default:
                break;
        }

    }
}
