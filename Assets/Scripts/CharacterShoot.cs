using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterShoot : MonoBehaviour
{
    private InputAction attackAction;
    private float rapidDelayTimer;
    

    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private float rapidDelay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
        rapidDelayTimer = 0;

    }

    private void OnDisable()
    {
        attackAction = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (rapidDelayTimer > 0)
        {
            rapidDelayTimer -= Time.deltaTime;
        }
    }

    public void Shoot()
    {
        if (rapidDelayTimer > 0) return;

        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        bullet.transform.forward = shootPoint.forward;
        //bullet.GetComponent<PlayerBullet>().SetVelocity(shootPoint.forward);
        rapidDelayTimer = rapidDelay;
    }
}
