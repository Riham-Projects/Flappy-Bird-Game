using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3; // Time in seconds between spawns
    private float timer = 0;
    public float heightOffset = 6; // Offset for the height of the pipes
                                   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) timer += Time.deltaTime;

        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
