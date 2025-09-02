using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string SceneName;
    public void Sceneload()
    {
        SceneManager.LoadScene(SceneName);
    }
}
