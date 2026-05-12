using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * GameManager
 * ---------
 * Manages and updates existing managers to handle time.
 */

public class GameManager : MonoBehaviour
{
    public static bool isPaused = false;

    public void TogglePause(bool pause)
    {
        isPaused = pause;
        // Freeze time at 0, then resume at 1 (0 is frozen, 1 is normal speed)
        Time.timeScale = pause ? 0f : 1f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Always reset time before loading!
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
