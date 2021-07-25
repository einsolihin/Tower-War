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

    public List<GameObject> EnemyTower = new List<GameObject>();
    public List<GameObject> PlayerTower = new List<GameObject>();
    public List<GameObject> EmptyTower = new List<GameObject>();

    private float playerScore, enemyScore;
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            gameObject.SetActive(false);
        }
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform t in towers.transform)
        {
            towerList.Add(t.GetComponent<TowerScript>());
            if (t.gameObject.GetComponent<TowerScript>().towerOwner == TowerScript.Owner.Enemy)
                EnemyTower.Add(t.gameObject);
            else if (t.gameObject.GetComponent<TowerScript>().towerOwner == TowerScript.Owner.Player)
                PlayerTower.Add(t.gameObject);
            else
                EmptyTower.Add(t.gameObject);
        }
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GetScore();
    }

    public void addTower(GameObject tower)
    {
        TowerScript.Owner towerOwner = tower.GetComponent<TowerScript>().towerOwner;

        switch(towerOwner)
        {
            case TowerScript.Owner.Empty:
                EmptyTower.Add(tower);
                break;
            case TowerScript.Owner.Enemy:
                EnemyTower.Add(tower);
                break;
            case TowerScript.Owner.Player:
                PlayerTower.Add(tower);
                break;
        }
    }

    public void removeTower(GameObject tower)
    {
        TowerScript.Owner towerOwner = tower.GetComponent<TowerScript>().towerOwner;

        switch (towerOwner)
        {
            case TowerScript.Owner.Empty:
                EmptyTower.Remove(tower);
                break;
            case TowerScript.Owner.Enemy:
                EnemyTower.Remove(tower);
                break;
            case TowerScript.Owner.Player:
                PlayerTower.Remove(tower);
                break;
        }

        if (EnemyTower.Count <= 0)
            GameOver();
        if (PlayerTower.Count <= 0)
            GameOver();
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
