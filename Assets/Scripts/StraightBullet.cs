using UnityEngine;

public class StraightBullet : MonoBehaviour
{
    //private Vector3 forward;
    //private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed;
    [SerializeField] private string bulletTag;
    [SerializeField] private GameObject explosionPrefab;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        transform.tag = bulletTag;
        SetVelocity();
    }

    void SetVelocity()
    {

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.linearVelocity = transform.forward * speed;
    }

    public void DestroyBullet()
    {
        GameObject vfx = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        foreach (Transform child in vfx.transform)
        {
            // 弾の大きさを合わせる
            child.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        //vfx.transform.localScale = new Vector3(explosionPrefabScale, explosionPrefabScale, explosionPrefabScale);
        Destroy(vfx, 1);
        Destroy(gameObject);
    }
}
