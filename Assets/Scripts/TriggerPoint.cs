using UnityEngine;

public class TriggerPoint : MonoBehaviour
{

    [SerializeField] private AudioClip triggerSfx;
    [SerializeField] private GameObject spawnVfx;
    [SerializeField] private Vector3 spawnVfxScale;
    [SerializeField] private Vector3 spawnVfxRotation;
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


        // 召喚エフェクトの大きさ調整
        foreach (Transform childVfx in spawnVfx.transform)
        {
            childVfx.localScale = spawnVfxScale;
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
                GameObject vfx = Instantiate(spawnVfx, child.position, Quaternion.Euler(spawnVfxRotation));
                Destroy(vfx, 0.5f);
                child.gameObject.SetActive(true);
            }
            isTriggered = true;
        }
    }
}
