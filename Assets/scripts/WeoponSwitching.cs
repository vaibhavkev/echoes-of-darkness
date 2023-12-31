using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeoponSwitching : MonoBehaviour
{
    public int selectedweopon = 1;
    void Start()
    {
        //selectweopon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousweopon = selectedweopon;
        /*if(Input.GetAxis("Mouse ScrollWheel") >  0f)
        {
            if (selectedweopon >= transform.childCount - 1)
                selectedweopon = 0;
            else
                selectedweopon++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedweopon <= 0)
                selectedweopon = transform.childCount - 1;
            else
                selectedweopon--;
        }
        if(previousweopon != selectedweopon)
        {
            selectweopon();
        }*/
    }
    /*private void selectweopon()
    {
        int i = 0;
        foreach(Transform weopon in transform)
        {
            if(i == selectedweopon)
                weopon.gameObject.SetActive(true);
            else
                weopon.gameObject.SetActive(false);
            i++;
        }
    }*/
}
