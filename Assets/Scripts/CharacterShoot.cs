using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterShoot : MonoBehaviour
{
    private float rapidDelayTimer;
    

    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private float rapidDelay;

    [SerializeField] private AudioClip shootSfx;

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

        AudioSource ase = GetComponent<AudioSource>();
        ase.PlayOneShot(shootSfx);

        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        bullet.transform.forward = shootPoint.forward;
        //bullet.GetComponent<PlayerBullet>().SetVelocity(shootPoint.forward);
        rapidDelayTimer = rapidDelay;
    }
}
