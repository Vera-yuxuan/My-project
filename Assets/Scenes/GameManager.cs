using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public PlayerScore playerScore;
    public static int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = FindObjectOfType<PlayerScore>();
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

    private IEnumerator IncreaseScoreOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playerScore.Score += 1;
            Debug.Log("Score increased over time! Current score: " + playerScore.Score);
        }
    }
}
