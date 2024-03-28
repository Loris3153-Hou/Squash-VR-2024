using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCounter : MonoBehaviour
{
    public Text compteurTexte;
    private int nbCollisionMur = 0;
    private int nbRebonds = 0;
    private int score = 0;
    private int rebondsSurMur = 0;
    private int rebondsSurRaquette = 0;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("raquette"))
        {
            rebondsSurRaquette++;
            Debug.Log("rebons raquette : " + rebondsSurRaquette);
        }

            if (collision.gameObject.CompareTag("sol"))
        {
            nbRebonds++;
            Debug.Log("rebons : " + nbRebonds);
            if (nbRebonds >= 2)
            {
                if (nbCollisionMur > score)
                {
                    score = nbCollisionMur;
                    UpdateCompterTexte();
                }
                nbRebonds = 0;
                nbCollisionMur = 0;
            }
        }

        if (collision.gameObject.CompareTag("wallFront"))
        {
            rebondsSurMur++;
            nbCollisionMur++;
            Debug.Log("collision : " +  nbCollisionMur);
            nbRebonds = 0;
        }
    }

    void UpdateCompterTexte()
    {
        if (compteurTexte != null)
        {
            compteurTexte.text = "Score : " + score.ToString();
        }
    }
    void Update()
    {
        PlayerPrefs.SetString("score", "Score : " + score);
        PlayerPrefs.SetString("rebondsMur", rebondsSurMur + " rebonds sur le mur");
        PlayerPrefs.SetString("rebondsRaquette", rebondsSurRaquette + " rebonds sur la raquette");
    }
}
