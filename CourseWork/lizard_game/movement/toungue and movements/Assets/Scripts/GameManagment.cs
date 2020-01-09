using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagment : MonoBehaviour
{
    public static bool won = false;
    private void Update()
    {
        if (won)
        {
            SceneManager.LoadScene("winner", LoadSceneMode.Single);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main_Game", LoadSceneMode.Single);
    }

    public void GameInformation()
    {
        SceneManager.LoadScene("Information_Page", LoadSceneMode.Single);
    }

    public void Back()
    {
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }

}
