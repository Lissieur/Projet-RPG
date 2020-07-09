using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keybind : MonoBehaviour
{
    public buttons inter;
    public KeyCode currentkey;
    public string bind;
    public Sprite sprite;
    public SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inter.state)
        {

            if (Input.GetKeyDown(KeyCode.Return))
            {
                inter.state = false; rend.enabled = true;
            }
            else
            {
                if (Input.anyKey)
                    rend.enabled = false;
                    char name = '*';
                    if (Input.inputString.Length== 1)
                         name = Convert.ToChar(Input.inputString);
                    string name2 = Input.inputString;
                    Debug.Log("name was " + name + " name2 was " + name2);
                    if (name >= 'a' && name <= 'z')
                    {
                        PlayerPrefs.SetString(bind, Convert.ToString(name - 32));
                        PlayerPrefs.Save();
                    }
                    else
                    {
                        PlayerPrefs.SetString(bind, name2);
                        PlayerPrefs.Save();
                    }
            }
        }
    }
}
