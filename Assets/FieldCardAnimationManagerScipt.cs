using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldCardAnimationManagerScipt : MonoBehaviour
{
    Animator CardAnimator;
    [SerializeField]
    private GameObject CardBody;

    void Awake()
    {
        CardAnimator = GetComponent<Animator>();
        transform.localScale.Set(0, 0, 0);
        
    }

    public void spawnThisCardWithAnimation(float offset)
    {

        CardBody.SetActive(true);
        CardAnimator.SetFloat("offset", offset);
        CardAnimator.SetTrigger("spawn");

    }

    public void despawnThisCardWithAnimation(float offset)
    {
        CardAnimator.SetFloat("offset", offset);
        CardAnimator.SetTrigger("despawn");

    }


}
