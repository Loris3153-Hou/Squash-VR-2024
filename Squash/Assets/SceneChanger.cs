using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int sceneMenu;
    public int sceneEntrainementStandard;
    public int sceneEntrainementLudique;
    public int sceneStats;
    public int scenePara;

    public void ChangeSceneMenu()
    {
        SceneManager.LoadScene(sceneMenu);
    }

    public void ChangeSceneEntrainementStandard()
    {
        SceneManager.LoadScene(sceneEntrainementStandard);
    }

    public void ChangeSceneEntrainementLudique()
    {
        SceneManager.LoadScene(sceneEntrainementLudique);
    }

    public void ChangeSceneStats()
    {
        SceneManager.LoadScene(sceneStats);
    }

    public void ChangeScenePara()
    {
        SceneManager.LoadScene(scenePara);
    }
}
