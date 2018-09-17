using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Camera cam;
    public GameObject gameOver;

    public void EndGame()
    {
        Debug.Log("GAME OVER");
        gameOver.SetActive(true);
    }
}
