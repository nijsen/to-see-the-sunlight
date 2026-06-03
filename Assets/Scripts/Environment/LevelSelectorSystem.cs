using UnityEngine;
using UnityEngine.SceneManagement;

namespace Environment
{
    public class LevelSelectorSystem : MonoBehaviour
    {
        [Header("Scene Configuration")]
        [SerializeField] private string nextLevelSceneName;
        [SerializeField] private string mainMenuSceneName = "UI_MainMenu";

        [Header("Visual Effects (Optional)")]
        [SerializeField] private GameObject levelTransitionPanel;

        private bool IsTransitioning = false;

        public void LoadNextLevel()
        {
            // Thread safety gate to trap overlapping call execution sequences
            if (IsTransitioning) return;

            if (!string.IsNullOrEmpty(nextLevelSceneName))
            {
                IsTransitioning = true;

                if (levelTransitionPanel != null)
                {
                    levelTransitionPanel.SetActive(true);
                }

                Debug.Log($"Transitioning from current runtime context to target scene: {nextLevelSceneName}");
                SceneManager.LoadScene(nextLevelSceneName);
            }
            else
            {
                Debug.LogWarning("LevelSelectorSystem allocation error: Target level string name is blank or missing.");
            }
        }

        public void EmergencyReturnToMenu()
        {
            Debug.Log("Resetting current level sequence loop. Directing flow to main UI structure.");
            SceneManager.LoadScene(mainMenuSceneName);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            // Restrict progression processing to authenticated player components exclusively
            if (other.CompareTag("Player"))
            {
                LoadNextLevel();
            }
        }
    }
}