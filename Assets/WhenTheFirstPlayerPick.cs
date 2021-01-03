using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhenTheFirstPlayerPick : MonoBehaviour
{
    [SerializeField] private GameObject PickText;
    private GameObject PlayersAnimationController;
    private Text changePickTextColor;

    private void Start()
    {
        PlayersAnimationController = GameObject.Find("PlayersAnimationController");
        changePickTextColor = PickText.GetComponent<Text>();
    }
    private void OnMouseEnter()
    {
        Debug.Log("this is first player");
        PlayersAnimationController.SetActive(true);
        PickText.SetActive(false);
        FindObjectOfType<PlayersAnimationController>().enableFirstPlayersImage();
    }

    private void OnMouseExit()
    {
        Debug.Log("Exit the collider!");
        PickText.SetActive(true);
        PlayersAnimationController.SetActive(false);
        //TODO(需要完成文字的缓慢出现）
        StartCoroutine(TextEnableEffecCo());
        
        /* GameObject.Find("Pick Text").SetActive(true);//MARKER Find只能找到active的*/
        /*        GameObject.Find("PlayersAnimationController").SetActive(false);*/
    }

    IEnumerator TextEnableEffecCo()//UNFINISHED
    {
        float fade = 0f;
        PickText.SetActive(true);
        changePickTextColor.color = new Color(26f / 255f, 26f / 255f, 26f / 255f,0f + Time.deltaTime);
        yield return new WaitForSeconds(0.7f);
        while(fade != 255)
        {
            Debug.Log("123");
            fade += Time.deltaTime;
            changePickTextColor.color = new Color(26f / 255f, 26f / 255f, 26f / 255f, fade);
        }
        
    }




}
