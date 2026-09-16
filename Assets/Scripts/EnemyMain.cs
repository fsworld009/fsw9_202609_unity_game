using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDeath()
    {

        GameManager.OnEnemyDeath(gameObject);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag) {
            case "PlayerBullet":
                CharacterDamage cd = GetComponent<CharacterDamage>();
                cd.ReceiveDamage(1);
                break;
            default:
                break;
        }
    }
}
