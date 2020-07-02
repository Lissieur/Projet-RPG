using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    interactable inter;
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        inter = GetComponent<interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inter.state)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
