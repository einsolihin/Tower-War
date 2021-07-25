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
        if (towerOwner == Owner.Player)
            AttackTarget(GameObject.Find("Tower (1)"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        setPossession();

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
        this.towerOwner = towerOwner;

        switch(towerOwner)
        {
            case Owner.Empty:
                SR.color = Color.gray;
                break;
            case Owner.Player:
                SR.color = Color.cyan;
                break;
            case Owner.Enemy:
                SR.color = Color.red;
                break;
        }
    }
    public void setPossession()
    {
        switch (towerOwner)
        {
            case Owner.Empty:
                SR.color = Color.gray;
                break;
            case Owner.Player:
                SR.color = Color.cyan;
                break;
            case Owner.Enemy:
                SR.color = Color.red;
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
            Debug.Log(dir);
            Vector2 unitPosition = new Vector2(transform.position.x*0.3f*i, transform.position.y*dir.y);

            GameObject setUnit = Instantiate(unitObject, unitPosition,Quaternion.identity);
            
            setUnit.transform.position = unitPosition;
            setUnit.GetComponent<UnitScript>().setTarget(target);
            setUnit.GetComponent<UnitScript>().unitOwner = towerOwner;

        }
    }
}
