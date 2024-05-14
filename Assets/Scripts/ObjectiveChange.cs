using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectiveChange : MonoBehaviour
{

    
    public TMP_Text currentObj;
    public string obj = "Visit the store for employment";
    // Start is called before the first frame update
    void Start()
    {
        currentObj.text = "Objective: " + obj.ToString();
    }



    // Update is called once per frame
    
}
