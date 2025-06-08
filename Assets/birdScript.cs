using UnityEngine;
using UnityEngine.InputSystem;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logicScript;
    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Riham's Bird";
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isAlive)
        {
            // Jump();
            myRigidbody.linearVelocity = Vector2.up * 5;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        isAlive = false;
    }
}
