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

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sol"))
        {
            nbRebonds++;
            if (nbRebonds >= 2)
            {
                if (nbCollisionMur > score || score == 0)
                {
                    score = nbCollisionMur;
                    UpdateCompterTexte();
                    nbCollisionMur = 0;
                    nbRebonds = 0;
                }
            }
            
        }

        if (collision.gameObject.CompareTag("wallFront"))
        {
            nbCollisionMur++;
            nbRebonds = 0;
        }
    }

    void UpdateCompterTexte()
    {
        if (compteurTexte != null)
        {
            compteurTexte.text = "Score : " + nbCollisionMur.ToString();
        }
    }
    void Update()
    {
        PlayerPrefs.SetString("score", "Score : " + score);
    }
}
