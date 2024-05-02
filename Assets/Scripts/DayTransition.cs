using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayTransition : MonoBehaviour
{
    private int count = 0;
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if(count == 300)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
