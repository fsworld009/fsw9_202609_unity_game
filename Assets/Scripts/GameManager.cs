using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    // (int)
    [SerializeField] private UnityEvent<int> onScoreUpdate = new UnityEvent<int>();

    static private GameManager instance;
    static private int score;



    void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void InitGame()
    {
        score = 0;
    }

    static public void OnEnemyDeath(GameObject enemy)
    {
        // TODO: check enemy type and decide score;
        AddScore(100);
    }

    static private void AddScore(int increase)
    {
        score += increase;
        instance.onScoreUpdate.Invoke(score);
    }


}
