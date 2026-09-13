using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
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

        attackAction = InputSystem.actions.FindAction("Attack");
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
        } else if (attackAction.IsPressed())
        {
            Shoot();
            rapidDelayTimer = rapidDelay;
        }
    }

    void Shoot()
    {
        Debug.Log("SHoot");
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        bullet.GetComponent<PlayerBullet>().SetVelocity(shootPoint.forward);
    }
}
