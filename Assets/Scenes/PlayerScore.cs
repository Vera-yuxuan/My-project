using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public event Action<int> OnScoreChanged;

    [SerializeField] private int score = 0;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            OnScoreChanged?.Invoke(score); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        Debug.Log("Started!");
    }
    private IEnumerator IncreaseScoreOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1); 
            score += 1;
            Debug.Log("Score increased over time! Current score: " + Score);
        }
    }

}
