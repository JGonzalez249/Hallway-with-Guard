using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody player;
    private Collider col;
    public float speed;
    public float MouseSensitivity;
    private float horizontalSpeed = 2.0f;
    private string[] stick;
    //    float verticalSpeed = 2.0f;

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Hit wall");
    }

    private void Start()
    {
        player = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        stick = Input.GetJoystickNames();
    }

    private void Update()
    {
        //if (stick.Length == 0){
        //moves player
        player.MoveRotation(player.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
        player.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * speed) + (transform.right * Input.GetAxis("Horizontal") * speed));

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        //        if (stick.Length == 1)
        if (Input.GetAxis("4th axis") != 0)
        {
            h = 0;
            h = horizontalSpeed * Input.GetAxis("4th axis");
        }

        player.transform.Rotate(0, h, 0);
        //}
    }
}