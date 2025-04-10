using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;

    void Start()
    {
    }

    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            endGamePanel.SetActive(true);
        }
    }
}
