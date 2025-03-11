using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotCardEventHandlerScript : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    private GameObject MenuStackGO;
    private ManuAnimatorScript MenuAnimatorScript_;
    [SerializeField]
    private int SlotNumber;


    private void Awake()
    {
        MenuAnimatorScript_ = MenuStackGO.GetComponent<ManuAnimatorScript>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        MenuAnimatorScript_.StartNewGameAnimationTrigger(SlotNumber);

    }
    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnPointerExit(PointerEventData eventData)
    {

    }

}
