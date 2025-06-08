using UnityEngine;

public class pipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5; // Speed at which the pipe moves
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the pipe to the left
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy the pipe if it goes off-screen
        if (transform.position.x < -20) // Adjust this value based on your camera's view
        {
            Destroy(gameObject);
        }

    }
}
