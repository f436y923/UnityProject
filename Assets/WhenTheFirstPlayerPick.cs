﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WhenTheFirstPlayerPick : MonoBehaviour
{
    [SerializeField] private GameObject PickText;
    private GameObject PlayersAnimationController;
    private Text changePickTextColor;
    private SpriteRenderer sp;
    private Sprite spriteA, spriteB;
    private void Start()
    {
        PlayersAnimationController = GameObject.Find("PlayersAnimationController");
        changePickTextColor = PickText.GetComponent<Text>();
        sp = this.GetComponent<SpriteRenderer>();
        spriteA = Resources.Load<Sprite>("Sprites/Scene02_06");//选中
        spriteB = Resources.Load<Sprite>("Sprites/Scene02_03");//没选中
    }
    private void OnMouseEnter()
    {
        PickText.SetActive(false);
        sp.sprite = spriteA;
        PlayersAnimationController.GetComponent<PlayersAnimationController>().EnableFirstPlayersImage();
    }

    private void OnMouseExit()
    {

        PickText.SetActive(true);
        sp.sprite = spriteB;
        PlayersAnimationController.GetComponent<PlayersAnimationController>().DisableImage();
        /*PickText.GetComponent<Text>().color = new Color(26f / 255f, 26f / 255f, 26f / 255f, fade + Time.deltaTime);*/ //IMPORTANT(会导致电脑卡掉)
        //TODO(需要完成文字的缓慢出现的动画，让转化不生硬）
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(2);
    }






}
