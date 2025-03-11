using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartnewGameEventHandlerScript : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private GameObject MenuStackGO;
    private ManuAnimatorScript MenuAnimatorScript_;

    private bool isopen = true;


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
        if (isopen)
        {
            //Debug.Log("Start new game animation and open slots");
            MenuAnimatorScript_.NewGameAnimationTrigger();
            isopen = false;
        }

    }
    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnPointerExit(PointerEventData eventData)
    {

    }

}
