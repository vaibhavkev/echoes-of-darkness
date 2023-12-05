using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadScenes(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        
    }
    async void delayG()
    {
        await Task.Delay(100);
    }
}
