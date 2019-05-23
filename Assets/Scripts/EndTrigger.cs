using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider end)
    {
        if(end.transform.tag == "Player")
        {   
            Debug.Log("here");
            gameManager.CompleteLevel();
        }
        else
        {
            Debug.Log("wall is triggering me!");
        }
    }
}
