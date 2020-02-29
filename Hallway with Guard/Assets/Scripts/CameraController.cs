using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float horizontalSpeed = 2.0f;
    private float verticalSpeed = -2.0f;

    private string[] sticky;

    // Start is called before the first frame update
    private void Start()
    {
        sticky = Input.GetJoystickNames();
    }

    // Update is called once per frame
    private void Update()
    {
        // Get the mouse delta. This is not in the range -1...1
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        //        if (sticky.Length == 1)
        if (Input.GetAxis("5th axis") != 0)
        {
            v = 0;
            v = verticalSpeed * Input.GetAxis("5th axis");
            v = -v;
        }
        transform.Rotate(v, 0, 0);
    }
}