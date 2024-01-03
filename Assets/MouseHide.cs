using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHide : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            Cursor.visible = false;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Cursor.visible = true;
        }

    }
}
