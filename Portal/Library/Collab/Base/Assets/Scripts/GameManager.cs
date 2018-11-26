using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
/** Handles game instance.
 */
public class GameManager : MonoBehaviour {
    public static GameManager instance = null;
    public GameObject youWin;
    GameObject button;

    /** Runs at start.
     *  @pre game starts
     *  @post Instance of the game is created
     */
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


        button = GameObject.FindGameObjectWithTag("button");
    }
    private void Update()
    {
        //ensure there is only one blue and one red portal
        GameObject[] portals;
        portals = GameObject.FindGameObjectsWithTag("portal_blue");

        if (portals.Length > 1)
        {
            Destroy(portals[1]);
        }
        portals = GameObject.FindGameObjectsWithTag("portal_red");

        if (portals.Length > 1)
        {
            Destroy(portals[1]);
        }

    }
    public void restartCurrentLevel()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    /** Sets win state to true.
     *  function is called by WinGame()
     *  @pre User reached door object
     *  @post Success message is displayed
     */
    public void Win()
    {
        youWin.SetActive (true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
