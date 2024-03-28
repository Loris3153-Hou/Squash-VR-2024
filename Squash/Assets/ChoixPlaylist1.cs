using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ChoixPlaylist1 : MonoBehaviour {

    public void SelectionPlaylist1() {
        GetComponent<Image>().color = new Color(157,157,157);
        GameObject btn = GameObject.Find("playlist2");
        btn.GetComponent<Image>().color = Color.white;
        btn = GameObject.Find("playlist3");
        btn.GetComponent<Image>().color = Color.white;
        btn = GameObject.Find("playlist4");
        btn.GetComponent<Image>().color = Color.white;
    }
}