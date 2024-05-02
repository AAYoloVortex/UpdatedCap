using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCount : MonoBehaviour
{

    public static MoneyCount instance;
    public GameObject locks;
    public GameObject locks2;
    public TMP_Text moneyText;
    public TMP_Text currentObj;
    public string obj = "Accumulate fourty dollars";
    public int currentMoney;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        moneyText.text = "$ " + currentMoney.ToString();
        currentObj.text = "Objective: " + obj.ToString();
        
    }



    // Update is called once per frame
    public void IncreaseMoney(int v)
    {
        currentMoney += v;
        Debug.Log(currentMoney);
        moneyText.text = "$ " + currentMoney.ToString();

        if(currentMoney == 40)
        {
            Destroy(locks);
            Destroy(locks2);
            obj = "Head for one of the shops";
            currentObj.text = "Objective: " + obj.ToString();
        }
    }
}
