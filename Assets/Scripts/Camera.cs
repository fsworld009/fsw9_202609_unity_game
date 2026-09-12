using System;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 1, -5);
    [SerializeField] private Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = player.TransformPoint(offset);
        transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
        //transform.position = player.position + (player.forward * offset);

        //transform.position = player.position;
        //transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
    }
}
