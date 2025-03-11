using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuEventClickScript : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
      
    [SerializeField]
    private GameObject MenuStackGO;
    private ManuAnimatorScript MenuAnimatorScript_;
    [SerializeField]
    private bool isfrontside;

    [SerializeField]
    private GameObject TopCard;
    private EventClickScript TopCardScript_;
    [SerializeField]
    private GameObject MidCard;
    private EventClickScript MidCardScript_;
    [SerializeField]
    private GameObject BotCard;
    private EventClickScript BotCardScript_;


    [SerializeField]
    private bool isPlayMenuCard;
    [SerializeField]
    private bool isSettingsMenuCard;
    [SerializeField]
    private bool isGameInfoMenuCard;

    private static bool initialClick = true;



    private void Awake()
    {
        MenuAnimatorScript_ = MenuStackGO.GetComponent<ManuAnimatorScript>();
        if (!isfrontside)
        {
            TopCardScript_ = TopCard.GetComponent<EventClickScript>();
            MidCardScript_ = MidCard.GetComponent<EventClickScript>();
            BotCardScript_ = BotCard.GetComponent<EventClickScript>();
        }
        
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
            MenuAnimatorScript_.menuCloseAnimationTrigger();
        }
        else{
            if (initialClick)
            {
                initialClick = false;

                MenuAnimatorScript_.menuOpenAnimationTrigger();
            }
            else
            {
                if (isPlayMenuCard)
                {
                    MenuAnimatorScript_.menuOpenMiddleAnimationTrigger();
                    TopCardScript_.closeCardfromOutside("Top Close Command");
                    BotCardScript_.closeCardfromOutside("Bot Close Command");
                }
                if (isSettingsMenuCard)
                {
                    MenuAnimatorScript_.menuOpenBottomAnimationTrigger();
                    TopCardScript_.closeCardfromOutside("Top Close Command");
                    MidCardScript_.closeCardfromOutside("Mid Close Command");
                }
                if (isGameInfoMenuCard)
                {
                    MenuAnimatorScript_.menuOpenTopAnimationTrigger();
                    MidCardScript_.closeCardfromOutside("Mid Close Command");
                    BotCardScript_.closeCardfromOutside("Bot Close Command");
                }
            }
            
        }
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnPointerExit(PointerEventData eventData)
    {

    }
}
