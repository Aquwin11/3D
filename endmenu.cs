using UnityEngine;
using UnityEngine.SceneManagement;

public class endmenu : MonoBehaviour
{
    public void escape()
    {
        Application.Quit();
    }
     public void Startgame()
    {
        SceneManager.LoadScene("startmenu");
    }
}
