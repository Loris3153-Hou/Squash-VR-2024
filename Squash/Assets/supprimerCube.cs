using UnityEngine;
using UnityEngine.UI;

public class supprimerCube : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubetaper;

    private void OnTriggerEnter(Collider other)
    {
        cube.SetActive(!cube.activeSelf);
        cubetaper.SetActive(!cubetaper.activeSelf);
    }


}
