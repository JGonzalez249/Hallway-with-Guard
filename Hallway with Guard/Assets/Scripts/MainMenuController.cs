using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

        public GameObject startButton;
        public GameObject quitButton;

	private string[] controls;

    // Start is called before the first frame update
    void Start()
    {
	controls = Input.GetJoystickNames();
    }

    // Update is called once per frame
    void Update()
    {
if (controls != null){
		if (Input.GetButtonDown("Fire3"))
		{
	            SceneManager.LoadScene("Hallway With Guard");
		}
		if (Input.GetButtonDown("Jump"))
		{
		        Application.Quit();
			Debug.Log("Quitter!");
		}
}
    }
}
