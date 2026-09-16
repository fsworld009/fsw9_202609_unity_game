using UnityEngine;

public class TriggerPoint : MonoBehaviour
{

    [SerializeField] private AudioClip triggerSfx;
    private Transform spawnObjs;
    bool isTriggered;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void OnEnable()
    {
        spawnObjs = transform.Find("SpawnObjs");
        isTriggered = false;
        foreach (Transform child in spawnObjs)
        {
            child.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered && other.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(triggerSfx);
            foreach (Transform child in spawnObjs)
            {
                child.gameObject.SetActive(true);
            }
            isTriggered = true;
        }
    }
}
