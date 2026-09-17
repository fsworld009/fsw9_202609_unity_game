using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = GameManager.GetScore();
        TextMeshProUGUI scoreText = transform.Find("ScoreNumber").GetComponent<TextMeshProUGUI>();
        scoreText.text = score.ToString("D6");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
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
