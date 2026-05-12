using UnityEngine;

/*
 * PauseMenu
 * ---------
 * Represents the pause menu UI.
 * Provides options to resume gameplay, restart the run, or return to the main menu.
 */

public class PauseMenu : Menu
{
    [SerializeField] private GameManager gameManager;

    public void ResumeGame()
    {
        gameManager.TogglePause(false);
        Close();
    }

    public void RestartRun()
    {
        gameManager.RestartGame();
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
