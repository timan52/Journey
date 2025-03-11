using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardManagerScript : MonoBehaviour
{
    [SerializeField]
    public string cardName;
    [SerializeField]
    public bool cardIsOpen;
    [SerializeField]
    public string cardtype; 

    [SerializeField]
    public int[] openCardValue;
    [SerializeField]
    public string[] openCardType;

    //combocounter=
    [SerializeField]
    public int cardParts;
    [SerializeField]
    public int cardLifes;

    [SerializeField]
    public bool hasPunish = false;

    [SerializeField]
    public int cardTier;
    [SerializeField]
    public Material Image;

    [SerializeField]
    private List<GameObject> Effects ;
    

    [SerializeField]
    private GameObject CardParts;
    [SerializeField]
    private GameObject CardName;
    [SerializeField]
    private GameObject CardLifes;
    [SerializeField]
    private GameObject CardFront;

    [SerializeField]
    private GameObject CardAnimationManager;

    [SerializeField]
    private GameObject thisCard;
    [SerializeField]
    public bool isfieldCard;

    [SerializeField]
    private GameObject EffectAnimator;
    private IconAnimationScript EffectAnimatorS;


    private void Start()
    {
        if (isfieldCard)
        {
            EffectAnimatorS = EffectAnimator.GetComponent<IconAnimationScript>();
            setRomanNum(CardParts, cardParts);
            CardName.GetComponent<TextMeshPro>().text = cardName;
            setRomanNum(CardLifes, cardLifes);    
            int index = 0;
            foreach (var item in openCardValue)
            {
                Effects[index].GetComponent<IconFinderScript>().setEffect(openCardValue[index], openCardType[index]);
                Effects[index].SetActive(true);
                index++;
            }
            
        }
        
        //CardFront.GetComponent<Renderer>().material = Image;
        
    }

    private void setRomanNum(GameObject go, int value)
    {
        string temp = "";
        if (value == 1)
        {
            temp = "I";
        }
        if (value == 2)
        {
            temp = "II";
        }
        if (value == 3)
        {
            temp = "III";
        }
        if (value == 4)
        {
            temp = "IV";
        }
        if (value == 5)
        {
            temp = "V";
        }
        if (value == 6)
        {
            temp = "VI";
        }
        go.GetComponent<TextMeshPro>().text = temp;
    }

    public void closeCard()
    {
       
        CardAnimationManager.GetComponent<CardAnimationManager>().closeAnimationTrigger();   
        cardIsOpen = false;
       
    }
    public void closeAll()
    {
        
        CardAnimationManager.GetComponent<CardAnimationManager>().closeAllAnimationTrigger();
        cardIsOpen = false;
    }
    public void checkCardLife()
    {
        
        if (cardLifes <= 0) { deleteCard(1); }
    }
    public void deleteCard(int time) 
    {
        
        //needs offset for last card animation
        CardAnimationManager.GetComponent<CardAnimationManager>().wantsToDie(thisCard, time);
    }

    public int getEffectValue(int counter)
    {
        cardIsOpen = true;
        if (counter> openCardValue.Length - 1)
        {
            EffectAnimatorS.fireEffect(openCardValue[openCardValue.Length - 1], openCardType[openCardType.Length - 1]);
            return openCardValue[openCardValue.Length - 1];
        }
        EffectAnimatorS.fireEffect(openCardValue[counter], openCardType[counter]);
        cardLifes -= 1;
        setRomanNum(CardLifes, cardLifes);
        return openCardValue[counter];
    }

    public string getEffectName(int counter)
    {
        if (counter > openCardType.Length - 1)
        {
            return openCardType[openCardType.Length - 1];
        }
        return openCardType[counter];
    }


}
