using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCollect : MonoBehaviour
{
    public int keyno;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        keyno = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = keyno.ToString() + "/5";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            Destroy(other.gameObject);
            keyno++;
        }   
    }
}
