using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class UnitScript : MonoBehaviour
{
    public GameObject target;
    public TowerScript.Owner unitOwner;

    AIDestinationSetter destination;
    Seeker seeker;
    Path path;
    SpriteRenderer SR;
    Animator anim;

    public AIPath aiPath;
    // Start is called before the first frame update
    void Start()
    {
        destination = GetComponent<AIDestinationSetter>();
        seeker = GetComponent<Seeker>();
        SR = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        setColour();
    }

    // Update is called once per frame
    void Update()
    {
        //If ai Reach the target
        destination.target = target.transform;
        if (aiPath.TargetReached)
            reachTarget();

        //Ai animation behavior
        if(aiPath.desiredVelocity.x>0)
        {
            if (aiPath.desiredVelocity.x < aiPath.desiredVelocity.y)
            {
                if (aiPath.desiredVelocity.y > 0)
                    anim.SetTrigger("Front");

                else 
                    anim.SetTrigger("Back");
            }
            else
                anim.SetTrigger("Right");
        }
        else
        {
            if (aiPath.desiredVelocity.x > aiPath.desiredVelocity.y)
            {
                if (aiPath.desiredVelocity.y > 0)
                    anim.SetTrigger("Front");

                else
                    anim.SetTrigger("Back");
            }
            else
                anim.SetTrigger("Left");
        }

        Debug.Log(aiPath.desiredVelocity);
    }

    public void reachTarget()
    {
        TowerScript targetTower = target.GetComponent<TowerScript>();
        if (targetTower.towerOwner == unitOwner)
        {
            targetTower.unit++;
        }
        else if(targetTower.towerOwner != unitOwner)
        {
            targetTower.unit--;
            if(targetTower.unit<=0)
            {
                targetTower.unit++;
                targetTower.setPossession(unitOwner);
            }
        }

        Destroy(gameObject);
    }

    public void setColour()
    {
        switch (unitOwner)
        {
            case TowerScript.Owner.Empty:
                SR.color = Color.gray;
                break;
            case TowerScript.Owner.Player:
                //SR.color = Color.cyan;
                anim.SetLayerWeight(1, 1f);
                break;
            case TowerScript.Owner.Enemy:
                anim.SetLayerWeight(0, 1f);
                //SR.color = Color.red;
                break;
        }
    }

    public void setTarget(GameObject target)
    {
        this.target = target;
    }
}
