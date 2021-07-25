using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    TowerScript playerTower;
    [SerializeField]
    Camera mainCamera;

    private NewInput controls;
    // Start is called before the first frame update
    private void Awake()
    {
        mainCamera = Camera.main;
        controls = new NewInput();
        Cursor.lockState = CursorLockMode.Confined;
    }
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    void Start()
    {
        controls.GamePlay.Click.started += _ => StartedClick();
        controls.GamePlay.Click.performed += _ => EndedClick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartedClick()
    {

    }
    public void EndedClick()
    {
        DetectObject();
        //action
    }

    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.GamePlay.Point.ReadValue<Vector2>());
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        if (hit.collider == null || hit.collider.tag != "Tower")
            return;

        //GameObject tower = hit.collider.gameObject;
        selectTower(hit.collider.gameObject);
    }

    public void attackTower(GameObject targetTower)
    {
        if (playerTower == null)
            return;
        playerTower.AttackTarget(targetTower);
    }

    public void selectTower(GameObject tower)
    {
        TowerScript towerScript = tower.GetComponent<TowerScript>();
        if (towerScript == playerTower)
            return;
        if (towerScript.towerOwner == TowerScript.Owner.Player)
            playerTower = towerScript;
        else
            attackTower(tower);
    }
}
