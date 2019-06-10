using UnityEngine.SceneManagement;
using UnityEngine;

public class continueToNextLevel : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Begin");
        SceneManager.LoadScene("Maze 1");
    }


}