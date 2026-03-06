using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClick() {
        SceneManager.LoadScene("Battle");
    }
}
