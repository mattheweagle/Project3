using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** Handles game instance.
 */
public class GameManager : MonoBehaviour {
    public static GameManager instance = null;
    public GameObject youWin;

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
    }

    /** Sets win state to true.
     *  function is called by WinGame()
     *  @pre User reached door object
     *  @post Success message is displayed
     */
    public void Win()
    {
        youWin.SetActive (true);
    }
}
