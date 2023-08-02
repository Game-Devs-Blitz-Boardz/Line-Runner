using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public bool gameStarted = false;

    public GameObject player;
    public TextMeshProUGUI scoreText;

    public int lives = 3;
    public int score = 0;

    void Awake()
    {
        instance = this;
    }

    public void StartGame() {
        gameStarted = true;
    }

    public void GameOver() {
        player.SetActive(false);

        Invoke("ReloadLevel", 1.5f);
    }

    public void ReloadLevel() {
        SceneManager.LoadScene("Game");
    }

    public void UpdateScore() {
        score++;
        scoreText.text = "score: " + score;
    }

}
