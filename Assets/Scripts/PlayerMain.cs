using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;
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
            GetComponent<CharacterDamage>().ReceiveDamage(damage);
        }
    }

    public void OnDeath()
    {
        GameObject vfx = Instantiate(explosionPrefab,
            new Vector3(transform.position.x, transform.position.y + 0.7f, transform.position.z), Quaternion.identity);
        Destroy(vfx, 1);
        Invoke(nameof(OnGameOver), 2);
        transform.Find("Character").gameObject.SetActive(false);
    }

    private void OnGameOver()
    {
        GameManager.OnGameOver();
    }
}
