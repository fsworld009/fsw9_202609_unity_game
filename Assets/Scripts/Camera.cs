using System;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{


    private List<(GameObject obj, Material mat)> blockedWalls; 
    [SerializeField] private Transform player;
    [SerializeField] LayerMask wallLayer;
    [SerializeField] Material transparentMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blockedWalls = new List<(GameObject obj, Material mat)>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ResetWallMaterials();
        blockedWalls.Clear();

        transform.position = player.Find("CameraPoint").position;
        transform.forward = player.Find("CameraPoint").forward;


        FindWallsInBetween();
        RenderTransparentWalls();

        //transform.position = player.position + (player.forward * offset);

        //transform.position = player.position;
        //transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
    }

    void ResetWallMaterials()
    {
        foreach (var wall in blockedWalls)
        {
            Renderer renderer = wall.obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = wall.mat;
            }
        }
    }

    void RenderTransparentWalls()
    {
        foreach (var wall in blockedWalls) {
            Renderer renderer = wall.obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = transparentMaterial;
            }
        }
    }

    void FindWallsInBetween()
    {
        Vector3 direction = player.transform.position - transform.position;
        RaycastHit[] hits = Physics.RaycastAll(transform.position, direction.normalized, direction.magnitude, wallLayer);
        foreach (RaycastHit hit in hits)
        {
            GameObject wall = hit.collider.gameObject;
            // Store the original material once
            Renderer renderer = wall.GetComponent<Renderer>();
            if (renderer != null)
            {
                blockedWalls.Add((wall, renderer.material));
            }
        }
    }
}
