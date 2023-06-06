using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene: MonoBehaviour
{
    public string sceneName;
    public void ChangeSceneName()
    {
        print("Changing...");
        SceneManager.LoadScene(sceneName);
    }
}
