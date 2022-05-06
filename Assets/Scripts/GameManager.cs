using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public GameObject gameOverUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            SceneManager.LoadScene("Main Menu");
        }
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Invoke("EndGame", 3f);
    }

}
