using UnityEngine;
using UnityEngine.UI;

public class ChoixPasPlaylist : MonoBehaviour {

    public Button bouton;
    private ColorBlock colors;

    public void Click() {
        bouton = GetComponent<Button>();
        colors = GetComponent<Button>().colors;
        colors.normalColor = Color.white;
        bouton.colors = colors;
    }
}