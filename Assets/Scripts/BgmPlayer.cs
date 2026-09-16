using UnityEngine;

public class BgmPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip bgm;
    [SerializeField] private float volume = 0.5f;
    [SerializeField] private bool loop = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource ase = GetComponent<AudioSource>();
        ase.volume = volume;
        ase.clip = bgm;
        ase.loop = loop;
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
