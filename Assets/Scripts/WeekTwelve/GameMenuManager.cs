using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace OwenLomax
{
    public class GameMenuManager : MonoBehaviour
    {

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // If our game menu panel is ACTIVE...
                if(GameMenuPanel.activeSelf == true)
                {
                    //HIDE it!..
                    HideGameMenuPanel();
                }
                // Otherwise..
                else
                {
                    // SHOW it!..
                    ShowGameMenuPanel();
                }
            }
        }

        // We need a Game UI with some menu buttons to send the user to the Main Menu scene
        // We want to show the UI when we press the escape key (ESC)

        [SerializeField] private GameObject GameMenuPanel;

        /// <summary>
        /// Sets the game menu panel to active.
        /// </summary>
        public void ShowGameMenuPanel()
        {
            GameMenuPanel.SetActive(true);
        }

        public void HideGameMenuPanel()
        {
            GameMenuPanel.SetActive(false);
        }

        public void ResumeGame()
        {
            Debug.Log("Resume game!");

            HideGameMenuPanel();
        }

        public void QuitToGameMenu()
        {
            Debug.Log("You've Quit to Main Menu");

            SceneManager.LoadScene(0);
        }

        public void LoadScene (int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}