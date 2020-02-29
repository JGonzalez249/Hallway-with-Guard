using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {        

if (GameObject.FindWithTag("Enemy")){
	if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("WinScreen");
        }
	}

    }
    void Start()
    {

    }


    void Update()
    {

    }
}
