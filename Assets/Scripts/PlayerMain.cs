using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        HandleDamage(collision.collider.tag);
    }

    private void OnTriggerEnter(Collider other)
    {
        HandleDamage(other.tag);
    }


    private void HandleDamage(string tag)
    {
        int damage = 0;
        switch (tag)
        {
            case "Enemy":
            case "EnemyBullet":
                damage = 1;
                break;
            default:
                break;
        }

        if (damage > 0)
        {
            GetComponent<CharacterDamage>().ReceiveDamange(damage);
        }
    }
}
