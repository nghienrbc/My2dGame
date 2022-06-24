using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    UIManager m_ui;
    public GameObject ball;
    public float spawnTime;
    float m_spawnTime = 0f;

    int m_score;
    bool m_isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        m_score = 0;
        m_spawnTime = 0f;
        m_isGameOver = false;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetScoreText("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (m_isGameOver)
        {
            m_spawnTime = 0;
            return;
        }

        if (m_spawnTime <= 0)
        { 
            SpawnBall();
            m_spawnTime = spawnTime;
        }
    }
    void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7f, 7f), 6);
        if (ball)
	    { 
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }

    public int GetScore()
    {
        return m_score;
    }

    public void SetScore(int score)
    {
        m_score = score;
    }

    public void IncreaseScore()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }
    public bool IsGameover()
    {
        return m_isGameOver;
    }
    public void SetGameOverState(bool state)
    {
        m_isGameOver = state;
        if (m_isGameOver)
        {
            m_ui.ShowPanel(true);
        }
    }

    public void PlayAgain()
    {
        m_score = 0;
        m_isGameOver = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.ShowPanel(false);
    }

}
