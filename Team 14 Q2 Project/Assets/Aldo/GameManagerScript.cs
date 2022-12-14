using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       // Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void quit()
    {
        Application.Quit();

        Debug.Log("Quit");
    }
}
