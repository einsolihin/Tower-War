using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject area;


    public static EnemyScript instance;

    public enum Behavior { wait, targetPlayer, targetEmpty, DistrurbPlayer}
    public Behavior enemyBehavior = Behavior.wait;

    public float waitTime = 1;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            gameObject.SetActive(false);
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime > 0)
            waitTime -= Time.deltaTime;
        else
        {
            int i = Random.Range(1, 10);
            //Debug.Log(i);
            if (i > 1)
                enemyBehavior = Behavior.targetPlayer;
            else
                enemyBehavior = Behavior.DistrurbPlayer;
            Status();
        }
    }

    public void Status()
    {
        switch(enemyBehavior)
        {
            case Behavior.wait:
                waitTime = Random.Range(1, 3);
                break;
            case Behavior.targetEmpty:
                foreach (GameObject g in GameManager.instance.EnemyTower)
                {
                    float gUnit = g.GetComponent<TowerScript>().unit;
                    foreach (GameObject e in GameManager.instance.EmptyTower)
                    {
                        float pUnit = e.GetComponent<TowerScript>().unit;
                        if (gUnit > pUnit + 5)
                        {
                            AttackTower(g.GetComponent<TowerScript>(), e);
                            break;
                        }
                    }
                }
                enemyBehavior = Behavior.wait;
                Status();
                break;
            case Behavior.targetPlayer:
                foreach(GameObject g in GameManager.instance.EnemyTower)
                {
                    float gUnit = g.GetComponent<TowerScript>().unit;
                    foreach (GameObject p in GameManager.instance.PlayerTower)
                    {
                        float pUnit = p.GetComponent<TowerScript>().unit;
                        if (gUnit>pUnit+5)
                        {
                            AttackTower(g.GetComponent<TowerScript>(), p);
                            break;
                        }
                    }
                }
                enemyBehavior = Behavior.targetEmpty;
                Status();
                break;
            case Behavior.DistrurbPlayer:
                int enemyTower = Random.RandomRange(0, GameManager.instance.EnemyTower.Count);
                int playerTower = Random.Range(0, GameManager.instance.PlayerTower.Count);

                GameObject enemy = GameManager.instance.EnemyTower[enemyTower];
                GameObject player = GameManager.instance.PlayerTower[playerTower];

                DistrubTower(enemy.GetComponent<TowerScript>(), player);

                enemyBehavior = Behavior.wait;
                Status();
                break;
        }
    }

    public void AttackTower(TowerScript enemyTower, GameObject targetTower)
    {
        float unit = targetTower.GetComponent<TowerScript>().unit/5;
        unit = Mathf.Round(unit)+1;
        for(int i =0;i<unit; i++)
        {
            enemyTower.AttackTarget(targetTower);
        }
        enemyBehavior = Behavior.wait;
    }
    public void DistrubTower(TowerScript enemyTower,GameObject targetTower)
    {
        enemyTower.AttackTarget(targetTower);
    }

}
