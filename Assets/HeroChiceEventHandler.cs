using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HeroChiceEventHandler : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    private GameObject GameSetup;
    private GameSetupScript GameSetupScript;
    [SerializeField]
    private int heroNumber;


    private void Awake()
    {
        GameSetup = GameObject.Find("GameSetup");
        GameSetupScript = GameSetup.GetComponent<GameSetupScript>();
       
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameSetupScript.sendHeroChoice_ToGameManager(heroNumber);
        

    }
    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnPointerExit(PointerEventData eventData)
    {

    }

}
