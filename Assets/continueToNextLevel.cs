using UnityEngine.SceneManagement;
using UnityEngine;

public class continueToNextLevel : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play game");
        SceneManager.LoadScene("Maze 1");
    }


}