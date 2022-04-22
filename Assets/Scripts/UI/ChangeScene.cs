using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadGameForOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGameForTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadOnlineGame()
    {
        SceneManager.LoadScene(3);
    }
}
