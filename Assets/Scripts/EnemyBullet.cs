using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        switch (collider.tag)
        {
            //case "Player":
            //    // EnemyÇÕColliderÇ∆TriggeréùÇ¬ÅAÇªÇÃÇ§ÇøÇÃColliderÇµÇ©îΩâûÇµÇ»Ç¢ÇÊÇ§Ç…
            //    if (collider.isTrigger) return;
            //    CharacterHealth eh = collider.gameObject.GetComponent<CharacterHealth>();
            //    if (eh != null)
            //    {
            //        eh.Damage();
            //    }
            //    Destroy(gameObject);
            //    break;
            case "Terrain": case "PlayerBullet":
            case "Player":
                GetComponent<StraightBullet>().DestroyBullet();
                break;
            default:
                break;
        }

    }
}
