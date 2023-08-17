using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManger;

    public void OnTriggerEnter()
    {
        gameManger.CompleteLevel();
    }
}
