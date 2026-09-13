using UnityEngine;

public class TriggerPoint : MonoBehaviour
{

    private SpawnPoint[] spawnPoints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPoints = GetComponentsInChildren<SpawnPoint>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (SpawnPoint spawnPoint in spawnPoints)
            {
                spawnPoint.Spawn();
            }
            Destroy(gameObject);
        }
    }
}
