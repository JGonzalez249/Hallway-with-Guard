using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private Rigidbody player;

    public GameObject enemy;

    private GameObject item;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (enemy != null)
            {
                GameObject g = Instantiate(enemy) as GameObject;

                g.name = "enemy";
            }

            Destroy(gameObject);
        }
    }

    private void Start()
    {

    }

    private void Update()
    {
    }
}