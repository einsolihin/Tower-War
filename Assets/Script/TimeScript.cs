using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text minuteTxt;
    [SerializeField]
    private TMP_Text secondTxt;

    public GameManager gameManager;

    private float minute, second;
    // Start is called before the first frame update
    void Start()
    {
        minute = 3f;
        second = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(second <=0)
        {
            if (minute > 0)
            {
                minute--;
                second = 59;
            }
            else
                gameManager.GameOver();
        }
        else if(second >0)
        {
            second -= Time.deltaTime;
        }

        //Set the text
        minuteTxt.text = minute.ToString("00");
        secondTxt.text = Mathf.Round(second).ToString("00");
    }
}
