using UnityEngine;
using UnityEngine.UI;

public class PressButton : MonoBehaviour
{
    [SerializeField]private Text text;

    virtual protected void OnMouseEnter()
    {
        text.color = Color.red;
    }

    virtual protected void OnMouseExit()
    {
        text.color = Color.black;
    }

    virtual protected void OnMouseDown()
    {
        text.color = Color.black;
    }

    virtual protected void OnMouseUp()
    {

    }

}
