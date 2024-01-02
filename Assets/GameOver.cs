using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Slider slider;
    public GameObject player;
    public GameObject Panel;
    public float timeValue = 180;
    // Start is called before the first frame update
    void CheckDeath()
    {
        if(slider.value <= 0 || timeValue == 0)
        {
            if (player.activeInHierarchy == true)
            {
                player.SetActive(false);
            }
            if (Panel.activeInHierarchy == false){
                Panel.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        CheckDeath();
    }
}
