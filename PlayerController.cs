using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float playerYPos;

    void Start()
    {
        playerYPos = transform.position.y;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            playerYPos = -playerYPos;

            transform.position = new Vector3(transform.position.x, playerYPos, transform.position.x);
        }
    }
}
