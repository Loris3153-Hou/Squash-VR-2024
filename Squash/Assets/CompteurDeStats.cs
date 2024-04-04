using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompteurDeStats : MonoBehaviour
{

    private int rebondsSurMur = 0;
    private int rebondsSurRaquette = 0;
    private int pourcentagePrecision = 0;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("raquette"))
        {
            rebondsSurRaquette++;
            Debug.Log("rebons raquette : " + rebondsSurRaquette);
        }

        if (collision.gameObject.CompareTag("wallFront"))
        {
            rebondsSurMur++;
            Debug.Log("collision sur mur : " + rebondsSurMur);
        }

        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("precision", calculPourcentageDePrecision() + "% de precision");
        PlayerPrefs.SetString("rebondsMur", rebondsSurMur + " rebonds sur le mur");
        PlayerPrefs.SetString("rebondsRaquette", rebondsSurRaquette + " rebonds sur la raquette");
    }

    float calculPourcentageDePrecision()
    {
        
        if (PlayerPrefs.GetInt("score_stat") != 0)
        {
            pourcentagePrecision = PlayerPrefs.GetInt("score_stat") * 100 / rebondsSurMur;
        }
        Debug.Log("precision : " + pourcentagePrecision);
        return pourcentagePrecision;
    }
    
}