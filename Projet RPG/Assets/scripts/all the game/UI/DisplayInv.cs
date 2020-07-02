using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInv : MonoBehaviour
{
    public Image img1;
    public Image img2;
    public Image img3;
    public Image img4;
    public Image img5;
    public Image img6;

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    bool activation = false;
    bool imageActiv = false;
    // Start is called before the first frame update
    void Start()
    {
        img1.enabled = false;
        img2.enabled = false;
        img3.enabled = false;
        img4.enabled = false;
        img5.enabled = false;
        img6.enabled = false;
        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        GetComponent<Canvas>().enabled = activation;
    }

 // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
         activation = !activation;
         GetComponent<Canvas>().enabled = activation;
        }
    }
    public void ActvImage1()
    {
        img1.enabled = true;
        text1.enabled = true;
    }
}
