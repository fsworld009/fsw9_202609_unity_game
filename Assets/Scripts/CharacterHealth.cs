using UnityEngine;
using UnityEngine.Events;

public class CharacterHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int maxHp = 3;
    [SerializeField] private UnityEvent<GameObject> onDeath = new UnityEvent<GameObject>();

    private int hp = 2;
    void Start()
    {
        
    }

    private void OnEnable()
    {
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Damage(int damage = 1)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
        return true;
    }

    private void Die()
    {
        //gameManager.AddScore(1);
        //GameManager.AddScore(100);
        onDeath.Invoke(gameObject);
        Destroy(gameObject);
    }
}
