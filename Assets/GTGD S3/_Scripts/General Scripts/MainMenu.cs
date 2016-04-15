using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace S3
{
    public class MainMenu : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene(1);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
