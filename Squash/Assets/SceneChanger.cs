using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int sceneMenu;
    public int sceneJouer;

    public void ChangeSceneMenu()
    {
        SceneManager.LoadScene(sceneMenu);
    }

    public void ChangeSceneJouer()
    {
        SceneManager.LoadScene(sceneJouer);
    }
}
