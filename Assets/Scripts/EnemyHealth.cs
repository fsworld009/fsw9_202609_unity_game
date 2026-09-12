using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private int hp = 2;
    void Start()
    {
        
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
        Destroy(gameObject);
    }
}
