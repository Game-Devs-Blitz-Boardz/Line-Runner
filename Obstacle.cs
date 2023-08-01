using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        // transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -10) {
            Destroy(gameObject);
        }
    }

}
