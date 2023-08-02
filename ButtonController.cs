using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void PlayButton() {
        SceneManager.LoadScene("Game");
    }

    public void QuitButton() {
        Application.Quit();
    }
}
