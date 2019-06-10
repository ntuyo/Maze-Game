using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider end)
    {
        if(end.transform.tag == "Player")
        {   
            Debug.Log("Level Passed");
            gameManager.CompleteLevel();
        }
        else
        {

        }
    }
}
