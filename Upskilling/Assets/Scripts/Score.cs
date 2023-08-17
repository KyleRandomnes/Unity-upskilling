using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        if (FindObjectOfType<GameManager>().gameEnded == true)
        {
            scoreText.text = "GAME OVER";
            Debug.Log(typeof(string).Assembly.ImageRuntimeVersion);
        }
    }
}
