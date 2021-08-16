using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class GameManager : MonoBehaviour
{
    public GameObject LevelCompleteUI;
    public void CompleteLevel()
    {
        LevelCompleteUI.SetActive(true);
    }
   public void EndGame()
    {
        Debug.Log("Game Over");
        Invoke("Restart", 3f);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
