using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text playerScoreText, enemyScoreText ,totalScoreText;
    public List<TowerScript> towerList = new List<TowerScript>();
    public GameObject towers,gameOverPanel;

    private float playerScore, enemyScore;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform t in towers.transform)
        {
            towerList.Add(t.GetComponent<TowerScript>());
        }
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GetScore();
    }

    public void GetScore()
    {
        playerScore = 0;
        enemyScore = 0;
        foreach (TowerScript t in towerList)
        {
            if (t.towerOwner == TowerScript.Owner.Player)
                playerScore += t.unit;
            else if (t.towerOwner == TowerScript.Owner.Enemy)
                enemyScore += t.unit;
        }
        playerScoreText.text = playerScore.ToString();
        
        enemyScoreText.text = enemyScore.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        totalScoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
