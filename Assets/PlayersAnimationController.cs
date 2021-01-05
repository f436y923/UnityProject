using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersAnimationController : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    public void EnableFirstPlayersImage()
    {
        anim.SetTrigger("PickFirstPlayer"); 
    }

    public void DisableImage()
    {
        anim.SetTrigger("BackToNormal");
    }

    public void EnableSecondPlayersImage()
    {
        anim.SetTrigger("PickSecondPlayer");
    }

    public void PickTextColorChange()
    {
        anim.SetTrigger("PickTextColorChange");
    }

}
