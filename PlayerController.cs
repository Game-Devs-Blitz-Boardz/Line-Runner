using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float playerYPos;
    int hits = 0;

    public GameObject[] lives;

    void Start()
    {
        playerYPos = transform.position.y;
        hits = 0;
        SetLivesActive();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            playerYPos = -playerYPos;

            transform.position = new Vector3(transform.position.x, playerYPos, transform.position.x);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Obstacle") {
            hits++;
            lives[lives.Length - hits].SetActive(false);
            if (hits == GameManager.instance.lives) {
                GameManager.instance.GameOver();
            }
        }
    }

    void SetLivesActive() {
        for (int i = 0; i<lives.Length; i++) {
            lives[i].SetActive(true);
        }
    }
}
