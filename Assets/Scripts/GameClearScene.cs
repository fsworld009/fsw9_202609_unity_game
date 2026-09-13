using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = GameManager.GetScore();
        TextMeshProUGUI scoreText = transform.Find("ScoreNumber").GetComponent<TextMeshProUGUI>();
        scoreText.text = score.ToString("D6");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTitleClicked()
    {
        SceneManager.LoadScene("Scenes/TitleScene");
    }
}
