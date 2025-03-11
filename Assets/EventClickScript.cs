using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClickScript : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    
    [SerializeField]
    private GameObject CardGO;
    private CardAnimationManager CardAnimationManager_;

    [SerializeField]
    private bool isfrontside;
    [SerializeField]
    private bool isMenuStackCard;
    private void Awake()
    {
        CardAnimationManager_ = CardGO.GetComponent<CardAnimationManager>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isfrontside)
        {
            //Debug.Log("I Close");
            CardAnimationManager_.closeAnimationTrigger();
        }
        else{
            //Debug.Log("I Open");
            CardAnimationManager_.openAnimationTrigger();
            if (isMenuStackCard) { CardAnimationManager_.resetTrigger(); }            
        }
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnPointerExit(PointerEventData eventData)
    {

    }

    public void closeCardfromOutside(string message)
    {
        if (isfrontside)
        {
            Debug.Log(message);
            CardAnimationManager_.closeAnimationTrigger();
        }
        else
        {
            //CardAnimationManager_.openAnimationTrigger();
        }
    }

}
