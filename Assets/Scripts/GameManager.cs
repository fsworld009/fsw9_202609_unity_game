using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // (int)
    [SerializeField] private UnityEvent<int> onScoreUpdate = new UnityEvent<int>();

    // TODO: change clear condition
    private int enemyDefeated = 0;

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
        instance.enemyDefeated = 0;
    }

    static private void AddScore(int increase)
    {
        score += increase;
        instance.onScoreUpdate.Invoke(score);

    }

    static public int GetScore()
    {
        return score;
    }



    static public void OnGameOver()
    {
        SceneManager.LoadScene("Scenes/GameOverScene");
    }

    static public void OnGameClear()
    {
        SceneManager.LoadScene("Scenes/GameClearScene");
    }


    static public void OnEnemyDeath(GameObject enemy)
    {
        // TODO: check enemy type and decide score;
        AddScore(100);
        instance.enemyDefeated += 1;
        if (instance.enemyDefeated >= 2)
        {
            OnGameClear();
        }
    }


}
