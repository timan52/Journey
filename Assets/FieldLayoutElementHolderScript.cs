using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldLayoutElementHolderScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Cardbody;

    

    private void Start()
    {
        setFieldCardTrue();
    }

    public void setFieldCardTrue()
    {
        Cardbody.GetComponent<CardAnimationManager>().isfieldCard = true;
    }
}
