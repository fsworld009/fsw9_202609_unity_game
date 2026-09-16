using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;

    [SerializeField] private AudioClip deathSfx;
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
        GameObject vfx = Instantiate(explosionPrefab,
            new Vector3(transform.position.x, transform.position.y + 0.7f, transform.position.z), Quaternion.identity);
        Destroy(vfx, 1);
        GameManager.OnEnemyDeath(gameObject);

        GetComponent<AudioSource>().PlayOneShot(deathSfx);

        transform.Find("Character").gameObject.SetActive(false);
        GetComponent<Collider>().enabled = false;

        Destroy(gameObject, deathSfx.length);
        
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
