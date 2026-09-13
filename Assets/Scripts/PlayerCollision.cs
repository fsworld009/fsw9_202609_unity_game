using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        int damage = 0;
        if (other.tag == "Enemy")
        {
            damage = 1;
        }
        if (damage > 0)
        {
            GetComponent<CharacterHealth>().Damage();
        }
    }
}
