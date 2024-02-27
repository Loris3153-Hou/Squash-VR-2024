using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int scene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
