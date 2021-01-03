using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadButton : PressButton
{
    [SerializeField] private GameObject buttonObject;
    [SerializeField] private GameObject LoadGameCanvas;



    protected override void OnMouseUp()
    {
        buttonObject.SetActive(false);
        LoadGameCanvas.SetActive(true);
    }


  
}
