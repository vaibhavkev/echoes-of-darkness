using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingData : MonoBehaviour
{
    [SerializeField] Image Progressbar;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneAsyc());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator LoadSceneAsyc()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("graveyard");
        while (operation.isDone)
        {
            Progressbar.fillAmount = operation.progress;
            yield return new WaitForEndOfFrame();
        }
    }
}
