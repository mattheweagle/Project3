using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Pauses the game and adds menu options
*/
public class Pause : MonoBehaviour
{
    private GameObject myBazooka;
    private GameObject[] knives;
    bool paused;
    /* Sets paused state to false
    */
    void Start()
    {
       paused = false;
    }
    /* Checks for esc key press, then pauses or unpauses if it is
    */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                PauseGame();
            }
            else
            {
                ContinueGame();
            }
        }
    }
    /* Displays pause menu
    */
    void OnGUI()
    {
        if (paused)
        {
            GUILayout.FlexibleSpace();
            GUILayout.Label("Game Paused");
            if (GUILayout.Button("Unpause"))
            {
                ContinueGame();
            }
            if (GUILayout.Button("Main Menu"))
            {
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
                ContinueGame();
            }
            if (GUILayout.Button("Quit Game"))
            {
                Application.Quit();
            }        
       }
    }
    /* Stops time, disables scripts
    */
    private void PauseGame()
    {
        Time.timeScale = 0;
        paused = true;
        //Disable scripts that still work while timescale is set to 0
        myBazooka = GameObject.FindWithTag("bazooka");
        myBazooka.GetComponent<ShootPortal>().enabled = !myBazooka.GetComponent<ShootPortal>().enabled;
        myBazooka.GetComponent<GunRotation>().enabled = !myBazooka.GetComponent<GunRotation>().enabled;
        knives = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject knife in knives)
        {
            knife.GetComponent<Knife>().enabled = !knife.GetComponent<Knife>().enabled;
        }
    }
    /* Resumes time, reenables scripts
    */
    private void ContinueGame()
    {
        Time.timeScale = 1;
        paused = false;
        //enable the scripts again
        myBazooka = GameObject.FindWithTag("bazooka");
        myBazooka.GetComponent<ShootPortal>().enabled = !myBazooka.GetComponent<ShootPortal>().enabled;
        myBazooka.GetComponent<GunRotation>().enabled = !myBazooka.GetComponent<GunRotation>().enabled;
        knives = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject knife in knives)
        {
            knife.GetComponent<Knife>().enabled = !knife.GetComponent<Knife>().enabled;
        }
    }
}