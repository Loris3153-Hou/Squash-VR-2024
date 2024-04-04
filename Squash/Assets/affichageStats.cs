using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class affichageStats : MonoBehaviour
{
    public Text NombreRebondsSurMur;
    public Text NombreRebondsSurRaquette;
    public Text PourcentagePrecision;
    // Start is called before the first frame update
    void Start()
    {
        NombreRebondsSurMur.text = PlayerPrefs.GetString("rebondsMur");
        NombreRebondsSurRaquette.text = PlayerPrefs.GetString("rebondsRaquette");
        if(PlayerPrefs.GetString("precision") != null){
            PourcentagePrecision.text = PlayerPrefs.GetString("precision");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
