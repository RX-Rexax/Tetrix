using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("p"))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);       // Hide the PauseMenu
        Time.timeScale = 1f;                // Set the game to normal speed (Resume Game)
        GameIsPaused = false;
    }

    void PauseGame()
    {
        pauseMenuUI.SetActive(true);        // Show the PauseMenu 
        Time.timeScale = 0f;                // Freeze the game (Pause the game)
        GameIsPaused = true;
    }

    public void quitGame()
    {
        Time.timeScale = 1f;                // Continue the game (if not the game is frozen)
        FindObjectOfType<GameManager>().EndGame();
        
    }
}
