using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeroCardScript : MonoBehaviour
{
    [SerializeField]
    public string HeroName;
    [SerializeField]
    public Material HeroImage;
    [SerializeField]
    public List<GameObject> HeroCards;
    [SerializeField]
    public int HP;
    [SerializeField]
    public int PW;
    

    [SerializeField]
    private GameObject thisPrefab;

    [SerializeField]
    public GameObject PWVis;
    [SerializeField]
    public GameObject HPVis;

    private NumberAnimManagerScript NAMS;
    [SerializeField]
    public GameObject NAM;
    private GameObject LooserCanvas;

    private void Awake()
    {
        LooserCanvas = GameObject.Find("LooserCanvas");
        NAMS = NAM.GetComponent<NumberAnimManagerScript>();
        HeroImage = GetComponent<Material>();
        //toDo get infos from UI
        updateHeroStats();
    }

    public int getTotalCards()
    {
        return HeroCards.Count;
    }

    public int getHeroAttack()
    {
        int atk = Random.Range(1, 6);

        return atk;
    }
    public GameObject getHeroPrefab()
    {
        return thisPrefab;
    }
    public void refreshStats()
    {
        HP = 10;
        PW = 4;
        updateHeroStats();
    }

    public void updateHeroStats()
    {
        PWVis.GetComponent<TextMeshPro>().text = PW.ToString();
        HPVis.GetComponent<TextMeshPro>().text = HP.ToString();
        if (HP <= 0)
        {
            LooserCanvas.GetComponent<Animator>().SetTrigger("trigger");
        }
    }


    public void getDMGonPW(int value)
    {
        NAMS.animatNumbers(value);
        PW += value;
        if (PW < 0)
        {
            HP += PW;
            PW = 0;
        }
    }
    public void changePW(int value)
    {
        NAMS.animatNumbers(value);
        PW += value;
        if (PW < 0)
        {
            PW = 0;
        }
    }

    public void getDMG(int value)
    {
        NAMS.animatNumbers(value);
        //if out diff types and effects
        HP += value;
        //updateHeroStats();
    }
    

}
