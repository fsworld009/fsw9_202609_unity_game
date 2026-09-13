using UnityEngine;
using UnityEngine.Events;

public class CharacterHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int maxHp = 3;
    [SerializeField] public UnityEvent<GameObject> onDeath = new UnityEvent<GameObject>();
    [SerializeField] public UnityEvent<int> onHealthUpdate = new UnityEvent<int>();

    private int hp = 2;
    void Start()
    {
        
    }

    private void OnEnable()
    {
        hp = maxHp;
        onHealthUpdate.Invoke(hp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        onDeath.RemoveAllListeners();
    }

    public bool Damage(int damage = 1)
    {
        hp -= damage;
        Debug.Log($"HP updated {hp}");
        onHealthUpdate.Invoke(hp);
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
    }
}
