using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimationManager : MonoBehaviour
{
    Animator CardAnimator;
    [SerializeField]
    private GameObject thisCard;
    [SerializeField]
    public bool isfieldCard;
    GameObject GM;
    GameManagerScript GMS;
    private void Awake()
    {
        CardAnimator = GetComponent<Animator>();
        GM = GameObject.Find("GameManager");
        GMS = GM.GetComponent<GameManagerScript>();


    }
    public void openAnimationTrigger()
    {
        CardAnimator.SetTrigger("OpenEvent");
        if (isfieldCard) 
        {
            GMS.openCard(thisCard);
        }
        
    }
    public void resetTrigger()
    {
        CardAnimator.ResetTrigger("CloseEvent");
    }


    public void closeAnimationTrigger()
    {
        CardAnimator.SetTrigger("CloseEvent");
        if (isfieldCard)
        {
            GMS.closeCard(thisCard);
            
            thisCard.GetComponent<CardManagerScript>().checkCardLife();
        }
    }
    public void closeAllAnimationTrigger()
    {
        CardAnimator.SetTrigger("CloseEvent");
        if (isfieldCard)
        {
            //GMS.closeCard(thisCard);
            //thisCard.GetComponent<CardManagerScript>().closeAll();
            thisCard.GetComponent<CardManagerScript>().checkCardLife();
        }
    }

    public void inHoverAnimationTrigger()
    {

    }

    public void outHoverAnimationTrigger()
    {

    }
    public void wantsToDie(GameObject GO, int time)
    {
        GMS.deletedCards++;
        GMS.checkCardCount();

        Destroy(GO, time);
    }

    /*public void spanAnimationTrigger(float offset)
    {
        CardAnimator.SetFloat(0, offset);
        CardAnimator.SetTrigger("SpawnCard");
    }*/
}
