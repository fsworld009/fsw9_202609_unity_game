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

    private void OnTriggerEnter(Collider other)
    {
        int damage = 0;
        switch (other.tag)
        {
            case "Enemy": case "EnemyBullet":
                damage = 1;
                break;
            default:
                break;
        }


        if (damage > 0)
        {
            GetComponent<CharacterDamage>().ReceiveDamange(damage);
        }



        //if (other.tag == "Enemy")
        //{
        //    damage = 1;
        //}
        //if (damage > 0)
        //{
        //    GetComponent<CharacterHealth>().Damage();
        //}
    }
}
