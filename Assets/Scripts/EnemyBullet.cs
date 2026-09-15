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
            case "Player":
                // Enemy‚ÍCollider‚ÆTrigger‚ÂA‚»‚Ì‚¤‚¿‚ÌCollider‚µ‚©”½‰‚µ‚È‚¢‚æ‚¤‚É
                if (collider.isTrigger) return;
                CharacterHealth eh = collider.gameObject.GetComponent<CharacterHealth>();
                if (eh != null)
                {
                    eh.Damage();
                }
                Destroy(gameObject);
                break;
            case "Terrain": case "PlayerBullet":
                Destroy(gameObject);
                break;
            default:
                break;
        }

    }
}
