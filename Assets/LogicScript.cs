using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int score = 0; // Player's score
    public Text scoreText; // UI Text to display the score
    public GameObject gameOverPanel; // Panel to show when the game is over
    [ContextMenu("Increment Score")]
    public void addScore()
    {
        score++; // Increment the score by the specified points
        scoreText.text = score.ToString(); // Update the UI Text with the new score
    }

    public void restartGame()
    {
        score = 0; // Reset the score to zero
        scoreText.text = score.ToString(); // Update the UI Text to reflect the reset score
                                           // Additional logic to reset the game can be added here, such as resetting bird position, pipes, etc.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene to restart the game
        gameOverPanel.SetActive(false); // Deactivate the Game Over panel
        Time.timeScale = 1; // Resume the game by setting the time scale back to ones
    }
    public void gameOver()
    {
        gameOverPanel.SetActive(true); // Activate the Game Over panel
        Time.timeScale = 0; // Pause the game by setting the time scale to zero
                            // Additional logic for game over can be added here, such as stopping bird movement, etc.

    }
}
