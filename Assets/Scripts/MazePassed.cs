using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class MazePassed : MonoBehaviour
{
    static int[] levels = { 2, 3, 4, 5, 6, 7 };
    static int maxLevels = 0;

    public void MazeCompleted()
    {
        maxLevels += 1;
        Debug.Log("Levels Left: " + (4 - maxLevels));

        int selectedlevel = Random.Range(2, 8);
        Debug.Log("Selected Level: " + selectedlevel);
        SceneManager.LoadScene(selectedlevel);        
        Debug.Log("Scene " + selectedlevel + " loaded.");

        int firstFoundIndex = Array.IndexOf(levels, selectedlevel);
        if (levels.Length >= 0)
        {
            levels = levels.Take(firstFoundIndex).Concat(levels.Skip(firstFoundIndex + 1)).ToArray();
        }
        Debug.Log("Level choices left to play: " + levels.Length);

        if (maxLevels >= 4)
        {
        SceneManager.LoadScene("Exit");     
        }
    }
}