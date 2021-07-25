using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TowerScript : MonoBehaviour
{
    //Component Variable
    SpriteRenderer SR;

    //Set The Owner
    public enum Owner { Player, Enemy, Empty}
    public Owner towerOwner = Owner.Empty;
    public GameObject unitObject;

    public List<Sprite> castleSprite = new List<Sprite>();

    //How many unit in the tower
    private float second = 1;
    public float unit;
    [SerializeField]
    private TMP_Text unitText;
    NewInput _newInput;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        setPossession();
        //if (towerOwner == Owner.Player)
        //    AttackTarget(GameObject.Find("Tower (5)"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Update the unit value
        if(towerOwner != Owner.Empty)
        {
            second -= Time.deltaTime;
            if (second <= 0)
            {
                second = 1;
                unit++;
            }
        }
        unitText.text = unit.ToString();

    }

    private void OnMouseDown()
    {
        Debug.Log("Hello World");
    }

    public void callOut()
    {
        Debug.Log("Hello World");
    }

    public void setPossession(Owner towerOwner)
    {
        //Remove the tower
        GameManager.instance.removeTower(this.gameObject);

        //add the tower
        this.towerOwner = towerOwner;
        GameManager.instance.addTower(this.gameObject);

        //Update the tower
        switch (towerOwner)
        {
            case Owner.Empty:
                SR.sprite = castleSprite[0];
                break;
            case Owner.Player:
                SR.sprite = castleSprite[2];
                break;
            case Owner.Enemy:
                SR.sprite = castleSprite[1];
                break;
        }
    }
    public void setPossession()
    {
        switch (towerOwner)
        {
            case Owner.Empty:
                SR.sprite = castleSprite[0];
                break;
            case Owner.Player:
                SR.sprite = castleSprite[2];
                break;
            case Owner.Enemy:
                SR.sprite = castleSprite[1];
                break;
        }
    }

    public void AttackTarget(GameObject target)
    {
        for(int i =0; i<5;i++)
        {
            Debug.Log("go");
            if (unit <= 0)
                break;
            unit--;
            Vector2 dir = (target.transform.position - transform.position).normalized;
            Vector2 unitPosition = new Vector2(transform.position.x+(0.3f*i), transform.position.y*dir.y);

            GameObject setUnit = Instantiate(unitObject, unitPosition,Quaternion.identity);
            
            setUnit.transform.position = unitPosition;
            setUnit.GetComponent<UnitScript>().setTarget(target);
            setUnit.GetComponent<UnitScript>().unitOwner = towerOwner;

        }
    }
}
