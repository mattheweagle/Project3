using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Handles switching between levels and main menu
*/
public class LevelSelector : MonoBehaviour {
    /* Changes scene to level 1
     */
    public void Level1()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
    /* Changes scene to level 2
     */
    public void Level2()
    {
        SceneManager.LoadScene("Level6", LoadSceneMode.Single);
    }
    /* Changes scene to level 3
     */
    public void Level3()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
    /* Changes scene to level 4 
     */
    public void Level4()
    {
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);
    }
    /* Changes scene to level 5 
     */
    public void Level5()
    {
        SceneManager.LoadScene("Level4", LoadSceneMode.Single);
    }
    /* Changes scene to level 6 
     */
    public void Level6()
    {
        SceneManager.LoadScene("Level5", LoadSceneMode.Single);
    }
    /* Changes scene to level 7 
     */
    public void Level7()
    {
        SceneManager.LoadScene("Level7", LoadSceneMode.Single);
    }
    /* Changes scene to level 8 
     */
    public void Level8()
    {
        SceneManager.LoadScene("Level8", LoadSceneMode.Single);
    }
    /* Changes scene to level 9 
     */
    public void Level9()
    {
        SceneManager.LoadScene("Level9", LoadSceneMode.Single);
    }
    /* Changes scene to main menu 
     */
    public void Menu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
