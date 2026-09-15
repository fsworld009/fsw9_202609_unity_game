using UnityEngine;

public class StraightBullet : MonoBehaviour
{
    //private Vector3 forward;
    //private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed;
    [SerializeField] string bulletTag;
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
}
