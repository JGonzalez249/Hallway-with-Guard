using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    //	bool seesPlayer;
    public Text alertText;


    private DebugLOS debugLOS;

    private void Start()
    {
    }

    private void Update()
    {
        GameObject debugLOSObject = GameObject.FindWithTag("Enemy");
        if (debugLOSObject != null)
        {
            debugLOS = debugLOSObject.GetComponent<DebugLOS>();
            if (debugLOS.sight == 2)
            {
                alertText.text = "!";
            }
        }
        if (debugLOSObject == null)
        {
            //            Debug.Log("hehe haha oops");
        }

        
    }

   

}