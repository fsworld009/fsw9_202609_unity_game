using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterJump : MonoBehaviour
{

    [SerializeField] private float jumpVelocity = 5;
    [SerializeField] private Transform groundCheckPoint;
    private bool isGround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGround = false;
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
        }
    }
}
