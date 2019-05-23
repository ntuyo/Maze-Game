using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void PlayAgain()
    {
        Debug.Log("Play Again");
        SceneManager.LoadScene("Maze 1");
    }


}
