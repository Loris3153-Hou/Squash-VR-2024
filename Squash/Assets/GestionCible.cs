using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionCible : MonoBehaviour
{
    public GameObject cible;
    public Text compteurTexte;
    private int score = 0;
    private int Niveau = 1;


    void Start()
    {
        this.deplacementCubeNiv1();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("balle"))
        {
            score++;
            this.UpdateCompterTexte();
            switch (score)
            {
                case > 10:
                    this.deplacementCubeNiv3();
                    break;
                case > 5:
                    this.deplacementCubeNiv2();
                    break;
                default:
                    this.deplacementCubeNiv1();
                    break;
            }
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
        PlayerPrefs.SetInt("score_stat", score);
        PlayerPrefs.SetString("score", "Score : " + score);
    }


    void deplacementCubeNiv1()
    {

        float actX = transform.position.x;
        float newY = Random.Range(13, 23);
        float newZ = Random.Range(-8, 8);
        transform.position = new Vector3(actX, newY/10, newZ/10);
    }

    void deplacementCubeNiv2()
    {

        float actX = transform.position.x;
        float newY = Random.Range(3, 33);
        float newZ = Random.Range(-18, 18);
        transform.position = new Vector3(actX, newY / 10, newZ / 10);
    }

    void deplacementCubeNiv3()
    {

        float actX = transform.position.x;
        float newY = Random.Range(3, 33);
        float newZ = Random.Range(-18, 18);
        float actScaleX = transform.localScale.x;
        float newScaleY = 4;
        float newScaleZ = 4;
        transform.localScale = new Vector3(actScaleX, newScaleY / 10, newScaleZ / 10);
        transform.position = new Vector3(actX, newY / 10, newZ / 10);
    }


}
