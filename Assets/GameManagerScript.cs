using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    private List<CardManagerScript> OpendCards;
    private CardManagerScript SecoundOpendCard;
    private CardManagerScript ThirdOpendCard;
    private CardManagerScript ForthOpendCard;

    [SerializeField]
    private GameObject Field;
    [SerializeField]
    private GameObject FieldHolder;
    [SerializeField]
    private GameObject PickedHeroCard;
    public HeroCardScript PickedHeroCardS;
    private HeroEffectEventHandlerScript HeroSc;
    [SerializeField]
    private GameObject PickedQuestCard;
    public QuestCardScript PickedQuestCardS;
    private HeroEffectEventHandlerScript QuestSc;

    public int deletedCards = 0;
    private int cardCount;

    [SerializeField]
    private GameObject Field1;
    [SerializeField]
    private GameObject Field12;
    [SerializeField]
    private GameObject Field14;
    [SerializeField]
    private GameObject Field16;
    [SerializeField]
    private GameObject Field18;


    [SerializeField]
    private GameObject Field1prefab;
    [SerializeField]
    private GameObject Field12prefab;
    [SerializeField]
    private GameObject Field14prefab;
    [SerializeField]
    private GameObject Field16prefab;
    [SerializeField]
    private GameObject Field18prefab;

    [SerializeField]
    private GameObject WinnerCanvas;

    [SerializeField]
    private GameObject RewardButton;
    [SerializeField]
    private GameObject RestartButton;

    [SerializeField]
    private int parts = 0;
    [SerializeField]
    private int openCounter = 0;

    [SerializeField]
    private GameObject OpenCounterVis;
    private void setfieldsizeold(int cardnumber) 
    {

        
        if (cardnumber > 24) 
        {
            
            Field = Field1;
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 7;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1f, 1f, 1f);
        }
        if (cardnumber < 24)
        {
            Field = Field12;
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 7;

            //FieldHolder.GetComponent<Transform>().localScale.Set(1.2f, 1.2f, 1f);
        }
        if (cardnumber < 21)
        {
            Field = Field12;
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 5;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.2f, 1.2f, 1f);
        }
        if (cardnumber < 16)
        {
            Field = Field14;
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 5;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.4f, 1.4f, 1f);
        }
        if (cardnumber < 13)
        {
            Field = Field16;
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 4;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.6f, 1.6f, 1f);
        }
        if (cardnumber < 10)
        {
            Field = Field16;
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 3;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.6f, 1.6f, 1f);
        }
        if (cardnumber < 7)
        {
            Field = Field18;
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 3;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.8f, 1.8f, 1f);
        }


    }

    public void checkCardCount()
    {
        
        if(deletedCards>= cardCount)
        {
            RestartButton.SetActive(true);
        }
    }
    public void resetHero()
    {
        
        PickedHeroCardS.refreshStats();
    }

    public void claimReward()
    {
        WinnerCanvas.GetComponent<Animator>().SetTrigger("trigger");
    }

    private void setfieldsize(int cardnumber)
    {    
        if (cardnumber > 24)
        {
            //Destroy(Field);
            Field = Instantiate(Field1prefab, FieldHolder.transform);
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 7;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1f, 1f, 1f);
        }
        if (cardnumber < 24 && cardnumber > 20)
        {
            //Destroy(Field);
            Field = Instantiate(Field12prefab, FieldHolder.transform);
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 7;

            //FieldHolder.GetComponent<Transform>().localScale.Set(1.2f, 1.2f, 1f);
        }
        if (cardnumber < 21 && cardnumber > 15)
        {
            //Destroy(Field);
            Field = Instantiate(Field12prefab, FieldHolder.transform);
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 5;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.2f, 1.2f, 1f);
        }
        if (cardnumber < 16 && cardnumber > 12)
        {
            //Destroy(Field);
            Field = Instantiate(Field14prefab, FieldHolder.transform);
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 5;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.4f, 1.4f, 1f);
        }
        if (cardnumber < 13 && cardnumber > 9)
        {
            //Destroy(Field);
            Field = Instantiate(Field16prefab, FieldHolder.transform);
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 4;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.6f, 1.6f, 1f);
        }
        if (cardnumber < 10 && cardnumber > 6)
        {
            //Destroy(Field);
            Field = Instantiate(Field16prefab, FieldHolder.transform);
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 3;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.6f, 1.6f, 1f);
        }
        if (cardnumber < 7)
        {
            //Destroy(Field);
            Field = Instantiate(Field18prefab, FieldHolder.transform);
            GridLayoutGroup GLG = Field.GetComponent<GridLayoutGroup>();
            GLG.constraintCount = 3;
            //FieldHolder.GetComponent<Transform>().localScale.Set(1.8f, 1.8f, 1f);
        }


    }
    private void Awake()
    {
        OpendCards = new List<CardManagerScript>();
    }
    public void openCard(GameObject CM) 
    {
        
        CardManagerScript CMS = CM.GetComponent<CardManagerScript>();
        
        if (parts == 0)
        {
            OpendCards.Add(CMS);
            HeroSc.handleCardAction(CMS.getEffectValue(0), CMS.getEffectName(0));
            parts = CMS.cardParts;
            openCounter += 1;
            OpenCounterVis.GetComponent<CombocounterCardVisS>().updateText(parts - openCounter + 1);
        }
        else
        {

            OpendCards.Add(CMS);
            HeroSc.handleCardAction(CMS.getEffectValue(openCounter), CMS.getEffectName(openCounter));
            
            if (parts == openCounter)
            {
                foreach (var card in OpendCards)
                {
                    card.deleteCard(2);
                }
                parts = 0;
                openCounter = 0;
                OpendCards = new List<CardManagerScript>();
                OpenCounterVis.GetComponent<CombocounterCardVisS>().updateText(0);
            }
            else { openCounter += 1; OpenCounterVis.GetComponent<CombocounterCardVisS>().updateText(parts - openCounter + 1); }
        }
        


    }

    public void closeCard(GameObject CM) 
    {
        checkCardCount();
        parts = 0;
        openCounter = 0;
        foreach (var item in OpendCards)
        {
            item.GetComponent<CardManagerScript>().closeAll();
        }
        OpendCards = new List<CardManagerScript>();
        OpenCounterVis.GetComponent<CombocounterCardVisS>().updateText(0);
    }


    public void setHeroCard(GameObject Hero)
    {
        PickedHeroCard = Hero;
        PickedHeroCardS = Hero.GetComponent<HeroCardScript>();
        HeroSc = PickedHeroCard.GetComponent<HeroEffectEventHandlerScript>();
    }

    public void setQuestCard(GameObject Quest)
    {
        PickedQuestCard = Quest;
        PickedQuestCardS = Quest.GetComponent<QuestCardScript>();
        QuestSc = PickedQuestCard.GetComponent<HeroEffectEventHandlerScript>();
    }

    public void deAcButton()
    {
        //RewardButton.SetActive(false);
        RestartButton.SetActive(false);
    }
    public void setUpGame()
    {
        deletedCards = 0;
        //Debug.Log("Load Field");
        OpendCards = new List<CardManagerScript>();
        List<GameObject> CardList = new List<GameObject>();
        PickedQuestCardS.resetQuest();
        Destroy(Field);
        foreach (var item in PickedHeroCard.GetComponent<HeroCardScript>().HeroCards)
        {
            CardList.Add(item);
        }

        foreach (var item in PickedQuestCard.GetComponent<QuestCardScript>().QuestCards)
        {
            CardList.Add(item);
        }
        setfieldsize(CardList.Count);
        cardCount = CardList.Count;
        
        float offset = 1;
        CardList.Sort((a, b) => 1 - 2 * Random.Range(0, CardList.Count));

        foreach (var item in CardList)
        {
            
            offset += 0.1f;
            GameObject Temp = Instantiate(item, Field.transform);
            Temp.GetComponent<FieldCardAnimationManagerScipt>().spawnThisCardWithAnimation(offset);
        }
        //load info from questcard to questcard on field
        //load info from herocard to herocard on field
        //setfieldsize and load and ini fieldcards
    }

}
