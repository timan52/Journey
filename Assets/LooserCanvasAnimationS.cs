using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooserCanvasAnimationS : MonoBehaviour
{
    [SerializeField]
    private Animator Anim;
    public void setTrigger()
    {
        Anim.SetTrigger("backtrigger");
    }
}
