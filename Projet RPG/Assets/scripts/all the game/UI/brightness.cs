using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brightness : MonoBehaviour
{
    private float opacity;
    public SpriteRenderer blackscreen;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("opacity-brightness", 0) == 0)
        {
            PlayerPrefs.SetFloat("opacity-brightness", 0);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Color col = blackscreen.color;
        blackscreen.color = new Color (col.r,col.g,col.b,PlayerPrefs.GetFloat("opacity-brightness"));
    }
}
