using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombocounterCardVisS : MonoBehaviour
{
    private TextMeshPro TM;
    // Start is called before the first frame update
    void Start()
    {
        TM = this.GetComponent<TextMeshPro>();
    }

    public void updateText(int number) 
    {
        if (number <= 0)
        {
            TM.text = "";
        }
        else
        {
            TM.text = number.ToString();
        }
    }
}
