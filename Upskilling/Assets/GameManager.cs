using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public float restartDelay = 5f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
            completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
