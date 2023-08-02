using UnityEngine;
using System.Collections;
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

    Vector3 cameraPos;

    void Awake()
    {
        instance = this;
    }

    void Start() {
        cameraPos = Camera.main.transform.position;
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

    public void Shake() {
        StartCoroutine(CameraShake());
    }

    IEnumerator CameraShake() {
        for (int i = 0; i<5; i++) {
            Vector2 randomPos = Random.insideUnitCircle * 1f;

            Camera.main.transform.position = new Vector3(randomPos.x, randomPos.y, cameraPos.z);

            yield return new WaitForSeconds(0.01f);
        }
        Camera.main.transform.position = cameraPos;
    }

}
