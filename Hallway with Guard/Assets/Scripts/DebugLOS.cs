using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DebugLOS : MonoBehaviour
{
    private Rigidbody player;
    private Rigidbody enemy;
    public float speed;
    public Text alertText;
    public int sight = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Did something here");
            SceneManager.LoadScene("GameOver");
        }
    }

    private void Start()
    {
        player = GetComponent<Rigidbody>();
        enemy = GetComponent<Rigidbody>();
        //	Text alertText = GameObject.FindGameObjectWithTag("AlertText").GetComponent<Text>();
        //	alertText.text = gameObject.GetComponent<Text>().text;

        Text alertText = GameObject.Find("Canvas/AlertText").GetComponent<Text>();
    }

    private void Update()
    {
        int layerMask = 1 << 8;

        layerMask = ~layerMask;

        RaycastHit hit;
        //Does the ray intersect anything
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            //           Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //            Debug.Log("Did Hit");
            //Does the ray intersect the player
            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("Hello");
                //                alertText.text = "!";
                // alertText.GetComponent<UnityEngine.UI.Text>().text = "!";
                sight = 2;
                Debug.Log(sight);
            }
        }
        else
        {
            //            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}