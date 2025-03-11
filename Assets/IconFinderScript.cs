using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IconFinderScript : MonoBehaviour
{
    [SerializeField]
    private Material FixProgress;

    [SerializeField]
    private Material FixDamage;
    [SerializeField]
    private Material PWDamage;
    [SerializeField]
    private Material PWRaise;
    [SerializeField]
    private Material ChangeGold;
    
    [SerializeField]
    private Material PWProgress;

    [SerializeField]
    private Material Combstopper;
    [SerializeField]
    private Material Combextender;

    [SerializeField]
    private Material ProgressDecrease;
    [SerializeField]
    private Material Heal;
    [SerializeField]
    private Material StealGold;
    [SerializeField]
    private Material PWLower;



    [SerializeField]
    private TextMeshPro Text;

    [SerializeField]
    private GameObject Plane;


    public void setEffect(int value, string effect)
    {
        if (value == 0)
        {
            Text.text = "";
        }
        else
        {
            Text.text = value.ToString();
        }

        if (effect == "Fix Progress")
        {
            Plane.GetComponent<MeshRenderer>().material = FixProgress;
        }
        if (effect == "FixDamage")
        {
            Plane.GetComponent<MeshRenderer>().material = FixDamage;
        }
        if (effect == "ChangeGold")
        {
            Plane.GetComponent<MeshRenderer>().material = ChangeGold;
        }
        if (effect == "PWDamage")
        {
            Plane.GetComponent<MeshRenderer>().material = PWDamage;
        }
        if (effect == "PWRaise")
        {
            Plane.GetComponent<MeshRenderer>().material = PWRaise;
        }
        if (effect == "Combstopper")
        {
            Plane.GetComponent<MeshRenderer>().material = Combstopper;
        }
        if (effect == "Combextender")
        {
            Plane.GetComponent<MeshRenderer>().material = Combextender;
        }
        if (effect == "PWProgress")
        {
            Plane.GetComponent<MeshRenderer>().material = PWProgress;
        }


        if (effect == "Progress Decrease")
        {
            Plane.GetComponent<MeshRenderer>().material = ProgressDecrease;
        }
        if (effect == "Heal")
        {
            Plane.GetComponent<MeshRenderer>().material = Heal;
        }
        if (effect == "StealGold")
        {
            Plane.GetComponent<MeshRenderer>().material = StealGold;
        }
        if (effect == "PWLower")
        {
            Plane.GetComponent<MeshRenderer>().material = PWLower;
        }


    }
    
}
