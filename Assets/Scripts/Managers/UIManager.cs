using UnityEngine;

/*
 * UIManager
 * ---------
 * Manages UI state and transitions between menus and HUD elements.
 * Responsible for showing, hiding, and switching UI screens.
 */
public class UIManager : MonoBehaviour
{
    // Variables

    [Header("Current State")]
    public Menu currentMenu;
    [SerializeField] private GameManager gameManager;

    [Header("Menu References")]
    public Menu mainMenu;
    public Menu settingsMenu;
    public PauseMenu pauseMenu;
    public Menu deathScreen;
    public Menu cardSelectionMenu;

    [Header("HUD")]
    public GameObject hud;

    void Update()
    {
        // Check for Escape key to pause/unpause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameManager.isPaused)
            {
                // If we are in gameplay, open the pause menu
                gameManager.TogglePause(true);
                ShowMenu(pauseMenu);
            }
            else if (currentMenu == pauseMenu)
            {
                // If we are already paused, resume gameplay
                pauseMenu.ResumeGame();
            }
        }
    }

    // Methods
    public void ShowMenu(Menu menu)
    {
        // Close any menu that is currently open
        if (currentMenu != null) currentMenu.Close();

        // Set the new menu as current and open it
        currentMenu = menu;
        if (currentMenu != null)
        {
            currentMenu.Open();
        }
        
        // Optionally hide HUD when a menu is open
        if (hud != null) hud.SetActive(false);
    }

    public void HideMenu()
    {
        if (currentMenu != null)
        {
            currentMenu.Close();
            currentMenu = null;
        }

        // Re-show HUD when menu is closed
        ShowHUD();
    }

    public void SwitchMenu(Menu menu)
    {
        // Logic for closing the current menu and opening a new one
        ShowMenu(menu);
    }

    public void ShowHUD()
    {
        if (hud != null) hud.SetActive(true);
    }
}