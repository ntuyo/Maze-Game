using UnityEngine;
using UnityEngine.SceneManagement;
using
public class MazePassed : MonoBehaviour
{


    int maxLevels = 0;
    String[] levels = { "2", "3","4", "5", "6" };
    public void MazeCompleted()
    {
        int index = Random.Range(2, 6);
        maxLevels += 1;
        int levelsLeft = levels.Length;
        
        for (int i = 0; i < levels.Length; i++)
            {
                 if(index.Equals(levels[i]))
                 {
                levels.Clear();
                 }
            }
       
        if(maxLevels == 4)
            {
                SceneManager.LoadScene(8);
            }
            else
            {
             SceneManager.LoadScene(index);
            Debug.Log("Scene " + index + " loaded.");
            }
        }

    }