using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroEffectEventHandlerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject GM;
    private GameManagerScript GMS;
    void Start()
    {
        GM = GameObject.Find("GameManager");
        GMS = GM.GetComponent<GameManagerScript>();
    }


    public void handleCardAction(int value, string effect)
    {
        
        if (effect == "Fix Progress")
        {//
            //calls animation that calls the below method at the end
            GMS.PickedQuestCardS.changeProgress(value);
        }
        if (effect == "Progress Decrease")
        {//
            //calls animation that calls the below method at the end
            GMS.PickedQuestCardS.changeProgress(value*-1);
        }

        if (effect == "FixDamage")
        {//
            GMS.PickedHeroCardS.getDMG(value*-1);
        }
        if (effect == "Heal")
        {//
            GMS.PickedHeroCardS.getDMG(value);
        }

        if (effect == "PWProgress")
        {//
            GMS.PickedHeroCardS.getDMGonPW(value*-1);
            GMS.PickedQuestCardS.changeProgress(value);
        }

        if (effect == "PWDamage")
        {//
            GMS.PickedHeroCardS.getDMGonPW(value*-1);
        }

        if (effect == "ChangeGold")
        {//
            GMS.PickedQuestCardS.changeGold(value);
        }
        
        if (effect == "StealGold")
        {///
            GMS.PickedQuestCardS.changeGold(value*-1);
        }

        if (effect == "PWRaise")
        {//
            GMS.PickedHeroCardS.changePW(value);
        }
        if (effect == "PWLower")
        {///
            GMS.PickedHeroCardS.changePW(value*-1);
        }

        if (effect == "Combstopper")
        {

        }
        if (effect == "Combextender")
        {

        }
        
        
    }
}
