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
                // TODO: CharacterDanage.ReceiveDamage()に変更
                CharacterHealth ch = GetComponent<CharacterHealth>();
                ch.Damage();
                break;
            default:
                break;
        }
    }
}
