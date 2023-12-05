using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage img;
    [SerializeField] private float x, y;
    public Vector2 a = new Vector2(0.15f, 0);
    public int d = 0;
    
    void Update()
    {  
        if(img.uvRect.position.x > a.x)
        {
            DarkBG();
        }
        else
        {
            img.uvRect = new Rect(img.uvRect.position + new Vector2(x, y) * Time.deltaTime, img.uvRect.size);
        }
        
    }
    async void DarkBG()
    {
        img.color = Color.black;
        await Task.Delay(100);
        img.uvRect = new Rect(new Vector2(0f,0f),img.uvRect.size);
        img.color = Color.white;
    }
}
