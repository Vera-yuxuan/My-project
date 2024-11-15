using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScore playerScore = FindObjectOfType<PlayerScore>();
        playerScore.OnScoreChanged += HandleScoreChanged;
    }

    private void HandleScoreChanged(int newScore)
    {
        if (newScore > highScore)
        {
            highScore = newScore;
            Debug.Log("New High Score: " + highScore);
        }
    }
}
