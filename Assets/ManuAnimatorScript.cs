using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuAnimatorScript : MonoBehaviour
{
    Animator MenuAnimator;
    [SerializeField]
    private GameObject ThisMenu;
    [SerializeField]
    private GameObject GameSetup;

    private void Awake()
    {
        MenuAnimator = GetComponent<Animator>();
        GameSetup = GameObject.Find("GameSetup");
        GameSetup.SetActive(false);
        
    }
    public void menuOpenAnimationTrigger()
    {
        MenuAnimator.SetTrigger("MoveMMtoML");

    }
    public void menuOpenMiddleAnimationTrigger()
    {
        MenuAnimator.SetTrigger("MiddleCard");

    }
    public void menuOpenTopAnimationTrigger()
    {
        MenuAnimator.SetTrigger("TopCard");

    }
    public void menuOpenBottomAnimationTrigger()
    {
        MenuAnimator.SetTrigger("BottomCard");

    }
    public void menuCloseAnimationTrigger()
    {
        MenuAnimator.SetTrigger("Close");

    }

    public void NewGameAnimationTrigger()
    {
        MenuAnimator.SetTrigger("NewGame");

    }

    public void StartNewGameAnimationTrigger(int slot)
    {
        //Debug.Log("start new game on slot " + slot);
        MenuAnimator.SetTrigger("StartNewGame");

    }

    public void deleteMenu()
    {
        Destroy(ThisMenu);
        GameSetup.SetActive(true);
    }


}
