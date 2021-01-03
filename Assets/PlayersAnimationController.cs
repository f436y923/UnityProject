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
    public void enableFirstPlayersImage()
    {
        anim.SetTrigger("PickFirstPlayer"); 
    }

    public void disableFirstPlayersImage()
    {
        anim.SetTrigger("BackToNormal");
    }

    public void enableSecondPlayersImage()
    {
        anim.SetTrigger("PickSecondPlayer");
    }

    public void disableSecondPlayersImage()
    {
        anim.SetTrigger("BackToNormal");
    }
}
