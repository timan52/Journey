using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestCardScript : MonoBehaviour
{
    [SerializeField]
    public string QuestName;
    [SerializeField]
    public Material QuestImage;
    [SerializeField]
    public List<GameObject> QuestCards;
    [SerializeField]
    public int questMaxProgess;
    [SerializeField]
    public int questProgess;
    [SerializeField]
    public int gold;
    [SerializeField]
    public int startgold;
    [SerializeField]
    public List<GameObject> QuestTressure;

    [SerializeField]
    private GameObject thisPrefab;

    [SerializeField]
    public GameObject QuestProgessMaxVis;
    [SerializeField]
    public GameObject QuestProgessCurrentVis;
    [SerializeField]
    public GameObject GoldVis;

    [SerializeField]
    private GameObject RewardButton;
    private GameObject GM;

    private NumberAnimManagerScript NAMS;
    [SerializeField]
    public GameObject NAM;
    private GameObject WinnerCanvas;
    
    private void Awake()
    {
        WinnerCanvas = GameObject.Find("WinnerCanvas");
        GM = GameObject.Find("GameManager");
        //RewardButton = GameObject.Find("RewardButton");
        
        questProgess = 0;
        NAMS = NAM.GetComponent<NumberAnimManagerScript>();
        QuestImage = GetComponent<Material>();
        //toDo get name and timer from UI
        updateQuestVis();
        
        QuestProgessMaxVis.GetComponent<TextMeshPro>().text = questMaxProgess.ToString();
    }

    private void Start()
    {
        //RewardButton.transform.localScale.Set(0,0,0);
    }

    public void resetQuest()
    {
        questProgess = 0;
        gold = startgold;
        updateQuestVis();
    }

    public int getTotalCards()
    {
        return QuestCards.Count;
    }

    public GameObject getQuestPrefab()
    {
        return thisPrefab;
    }

    public void updateQuestVis()
    {
        
        QuestProgessCurrentVis.GetComponent<TextMeshPro>().text = questProgess.ToString();
        GoldVis.GetComponent<TextMeshPro>().text = gold.ToString();

        if(questProgess >= questMaxProgess)
        {
            GM.GetComponent<GameManagerScript>().claimReward();
            //RewardButton.transform.localScale.Set(1, 1, 1);
            //RewardButton.SetActive(true);
        }
    }

    

    public void changeProgress(int value)
    {
        NAMS.animatNumbers(value);
        questProgess += value;
        if (questProgess < 0)
        {
            questProgess = 0;
        }

        //updateQuestVis();
    }
    public void changeGold(int value)
    {
        NAMS.animatNumbers(value);
        gold += value;
        if (gold < 0)
        {
            gold = 0;
        }

        //updateQuestVis();
    }

}
