using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetupScript : MonoBehaviour
{
    [SerializeField]
    private GameObject GameSetup;
    [SerializeField]
    private GameObject GameManager;
    private GameManagerScript GMS;
    
    [SerializeField]
    private GameObject JourneyInterface;

    [SerializeField]
    private GameObject HeroCardOne;
    [SerializeField]
    private GameObject HeroCardTwo;
    [SerializeField]
    private GameObject HeroCardThree;

    [SerializeField]
    private GameObject QuestCardOne;
    [SerializeField]
    private GameObject QuestCardTwo;
    [SerializeField]
    private GameObject QuestCardThree;

    [SerializeField]
    private List<GameObject> Children;

    private Animator GameSetupAnimator;
    private GameObject HeroCard;
    private GameObject QuestCard;
    private GameObject TempCanvas;
    private void Awake()
    {
        TempCanvas = GameObject.Find("TempCanvas");
        GameSetupAnimator = GetComponent<Animator>();
        GMS = GameManager.GetComponent<GameManagerScript>();
    }
    public void GameSetupSetInActive()
    {
        JourneyInterface.GetComponent<JourneyInterfaceScript>().initinalLoad(HeroCard, QuestCard);
        //GameSetup.SetActive(false);
        setChildrenInActive();
    }
    public void setChildrenInActive()
    {
        foreach (var item in Children)
        {
            item.SetActive(false);
        }
    }

    public void sendHeroChoice_ToGameManager(int heroNumber)
    {
        //TempCanvas.SetActive(true);
        if (heroNumber == 1)
        {
            // HeroCard = HeroCardOne.GetComponent<HeroCardScript>().getHeroPrefab();
            HeroCard = HeroCardOne.GetComponent<HeroCardScript>().getHeroPrefab();
            GMS.setHeroCard(HeroCardOne);
            GameSetupAnimator.SetTrigger("HeroOne");
        }
        if (heroNumber == 2)
        {
            //is Not added to the GO
            GMS.setHeroCard(HeroCardTwo);
            GameSetupAnimator.SetTrigger("HeroTwo");
        }
        if (heroNumber == 3)
        {
            //is Not added to the GO
            GMS.setHeroCard(HeroCardThree);
            GameSetupAnimator.SetTrigger("HeroThree");
        }

        //temp
        //QuestCard = QuestCardOne;
        QuestCard = QuestCardOne.GetComponent<QuestCardScript>().getQuestPrefab();
        GMS.setQuestCard(QuestCardOne);

    }
    public void sendHeroChoice_Two_ToGameManager()
    {
        GMS.setHeroCard(HeroCardTwo);
    }
    public void sendHeroChoice_Three_ToGameManager()
    {
        GMS.setHeroCard(HeroCardThree);
    }


}
