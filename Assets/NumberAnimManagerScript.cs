using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberAnimManagerScript : MonoBehaviour
{
    TextMeshPro text;
    Animator anim;
    [SerializeField]
    private GameObject Parent;
    [SerializeField]
    private bool isquestanim;

    private void Awake()
    {
        anim = this.GetComponent<Animator>();
        text = this.GetComponent<TextMeshPro>();
    }
    public void animatNumbers(int value, string type)
    {
        if (value == 0) { }
        else
        {
            
            if (value < 0) 
            {
                text.color = new Color(255, 0, 0);
                text.text = value + " " + type;
            }
            if (value > 0)
            {
                text.color = new Color(0, 255, 0);
                text.text ="+" + value + " " + type;
            }

            anim.SetTrigger("shownum");
        }
        
    }
    public void animatNumbers(int value)
    {
        if (value == 0) { }
        else
        {
            
            if (value < 0)
            {
                text.color = new Color(255, 0, 0);
                text.text = value.ToString();
            }
            if (value > 0)
            {
                text.color = new Color(0, 255, 0);
                text.text = "+" + value.ToString();
            }

            anim.SetTrigger("shownum");
        }

    }
    public void afteranimation()
    {
        
        if (isquestanim)
        {
            
            Parent.GetComponent<QuestCardScript>().updateQuestVis();
        }
        else 
        {
            Parent.GetComponent<HeroCardScript>().updateHeroStats();
        }
    }
}
