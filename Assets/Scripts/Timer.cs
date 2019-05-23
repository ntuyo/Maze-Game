using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Timer : MonoBehaviour
{
    public float timer = 20f;
    private Text timerSeconds;
    private bool timerIsActive = true;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsActive)
        {
            if(timer>= 0)
            {
            timer -= Time.deltaTime;
            timerSeconds.text = timer.ToString("f1");
            }
            else if (timer <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        
        
    }
    public void Pause()
    {
        timerIsActive = false;
        timerSeconds.Equals("1");
    }
}
