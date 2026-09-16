using UnityEngine;
using UnityEngine.Events;

public class CharacterHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float maxHp = 3;
    [SerializeField] public UnityEvent<GameObject> onDeath = new UnityEvent<GameObject>();
    [SerializeField] public UnityEvent<float> onHpUpdate = new UnityEvent<float>();

    private float hp = 2;
    void Start()
    {
        
    }

    private void OnEnable()
    {
        hp = maxHp;
        //onHpUpdate.Invoke(GetHpRate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        onDeath.RemoveAllListeners();
    }

    public bool Damage(float damage = 1)
    {
        hp -= damage;
        onHpUpdate.Invoke(GetHpRate());
        if (hp <= 0)
        {
            Die();
        }
        return true;
    }

    private void Die()
    {
        onDeath.Invoke(gameObject);
    }

    public bool IsDead() { return hp <= 0; }

    public float GetHpRate() { return hp / maxHp; }
}
