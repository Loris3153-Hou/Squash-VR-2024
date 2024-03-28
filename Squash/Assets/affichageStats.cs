using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class affichageStats : MonoBehaviour
{
    public Text NombreRebondsSurMur;
    public Text NombreRebondsSurRaquette;
    // Start is called before the first frame update
    void Start()
    {
        NombreRebondsSurMur.text = PlayerPrefs.GetString("rebondsMur");
        NombreRebondsSurRaquette.text = PlayerPrefs.GetString("rebondsRaquette");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
