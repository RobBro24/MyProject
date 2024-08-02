using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public PlayerCollision pc;
    void Update()
    {
        scoreText.text = pc.score.ToString();
    }
}
