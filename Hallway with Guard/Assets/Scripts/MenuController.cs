using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{


    public GameObject pauseMenu;
    public bool isPaused;


	private string[] controls;


    // Start is called before the first frame update
    void Start()
    {
        	controls = Input.GetJoystickNames();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ContinueGame();
            }
            else
            {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }



if (controls != null){
	        if (Input.GetButtonDown("Fire2"))
        {
            if (isPaused)
            {
                ContinueGame();
            }
            else
            {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        
		if (Input.GetButtonDown("Fire3"))
		{
            if (isPaused)
            {
	            SceneManager.LoadScene("Hallway With Guard");
            }
		}
		if (Input.GetButtonDown("Jump"))
		{
            	if (isPaused)
            	{
		        Application.Quit();
			Debug.Log("Quitter!");
		}
		}
	}

}





    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUITER!");
    }

    public void BeginGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Hallway with Guard");
    }

    public void ContinueGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }


}