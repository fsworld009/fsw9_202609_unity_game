using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnScoreUpdate(int score)
    {
        TextMeshProUGUI scoreText = transform.Find("ScoreNumber").GetComponent< TextMeshProUGUI>();
        scoreText.text = score.ToString("D6");
    }

    public void OnPlayerHpUpdate(int hp)
    {
        TextMeshProUGUI hpText = transform.Find("PlayerHP").GetComponent<TextMeshProUGUI>();
        hpText.text = hp.ToString();
    }
}
