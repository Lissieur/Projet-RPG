using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brightness_bar : MonoBehaviour
{
    public interactable inter;
    public Transform cursor;
    public float opacity;
    // Start is called before the first frame update
    void Start()
    {
        cursor.SetPositionAndRotation(new Vector3(PlayerPrefs.GetFloat("cursor-posx",cursor.position.x), cursor.position.y, cursor.position.z), cursor.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (inter.state)
        {
            if (Input.GetKey(KeyCode.D) && cursor.position.x < 1.3f)
            {
                cursor.SetPositionAndRotation(new Vector3(cursor.position.x + 0.0125f, cursor.position.y, cursor.position.z), cursor.rotation);
            }
            if (Input.GetKey(KeyCode.Q) && cursor.position.x > -0.43f)
            {
                cursor.SetPositionAndRotation(new Vector3(cursor.position.x - 0.0125f, cursor.position.y, cursor.position.z), cursor.rotation);
            }
        }
        opacity = (1.75f - (cursor.position.x + 0.45f))/1.75f;
        PlayerPrefs.SetFloat("cursor-posx", cursor.position.x);
        PlayerPrefs.SetFloat("opacity-brightness", opacity);
        PlayerPrefs.Save();
        
    }
}
