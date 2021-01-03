using UnityEngine.SceneManagement;

public class StartButton : PressButton
{
    protected override void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}
