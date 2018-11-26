using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/* Main menu functionality
*/
public class MainMenu : MonoBehaviour {

    /* Begins level 1
    */
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /* Changes scene to level select screen
     */
    public void Levels()
    {
        SceneManager.LoadScene("LevelSelect", LoadSceneMode.Single);
    }
    /*
     * Changes to testing scene
     */
    public void Test()
    {
        SceneManager.LoadScene("TestResult", LoadSceneMode.Single);
    }
    /* Exits game
    */
    public void QuitGame ()
    {
        Application.Quit();
    }
}
