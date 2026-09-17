using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterJump : MonoBehaviour
{

    [SerializeField] private float jumpVelocity = 5;
    [SerializeField] private Transform groundCheckPoint;
    [SerializeField] private AudioClip jumpSfx;
    private bool isGround;

    void OnEnable()
    {

        isGround = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(groundCheckPoint.position, 0.2f, LayerMask.GetMask("Ground"));
    }

    public void Jump()
    {
        if (isGround)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = Vector3.up * jumpVelocity;
            AudioSource ase = GetComponent<AudioSource>();
            ase.PlayOneShot(jumpSfx);
        }
    }
}
