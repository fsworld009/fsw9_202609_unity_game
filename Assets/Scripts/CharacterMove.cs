using UnityEngine;
using UnityEngine.UIElements;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float rotateSpeed = 1;


    private Vector3 moveDir;
    private Vector3 moveRot;

    private float moveSpeedOverride;

    void OnEnable()
    {
        moveDir = Vector3.zero;
        moveRot = Vector3.zero;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (moveDir != Vector3.zero)
        {
            float speed = moveSpeedOverride > 0 ? moveSpeedOverride : moveSpeed;
            rb.MovePosition(rb.position + (moveDir * Time.deltaTime * speed));
            moveDir = Vector3.zero;
            moveSpeedOverride = 0;
        }

        if (moveRot != Vector3.zero)
        {
            rb.MoveRotation(Quaternion.Euler(rb.rotation.eulerAngles + (moveRot * Time.deltaTime * rotateSpeed)));
            moveRot = Vector3.zero;
        }

    }

    public void Move(Vector3 direction, float speedOverride = 0) {
        moveDir = 
            transform.right * direction.x +
            transform.up * direction.y +
            transform.forward * direction.z;
        if (speedOverride > 0)
        {
            moveSpeedOverride = speedOverride;
        }
    }

    public void Rotate(Vector3 rotation)
    {
        moveRot = rotation;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public void LookAt(Vector3 pos, float delay)
    {
        transform.LookAt(pos);
    }

}
