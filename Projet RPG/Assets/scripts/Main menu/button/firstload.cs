using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("up", "Z");
        PlayerPrefs.SetString("left", "Q");
        PlayerPrefs.SetString("down", "S");
        PlayerPrefs.SetString("right", "D");
        PlayerPrefs.SetString("dodge", "P");
        PlayerPrefs.SetString("sprint", "LeftShift");
        PlayerPrefs.Save();
        if (PlayerPrefs.GetInt("firstdone", 0) == 0)
        {
            PlayerPrefs.SetInt("firstdone", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
