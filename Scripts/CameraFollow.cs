using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    public float scroll = 0.01f;

    private float edge; // position of the left edge of the camera with respect to center

    private void Start()
    {
        edge = cam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // scroll to the side
        transform.position = new Vector3(transform.position.x + scroll, transform.position.y, transform.position.z);
        // move the player if the camera is too fast
        if (transform.position.x + edge > target.position.x)
            target.position = new Vector3(target.position.x + scroll, target.position.y, target.position.z);
        // move the camera if the player is too fast
        if (transform.position.x - edge < target.position.x)
            transform.position = new Vector3(target.position.x + edge, transform.position.y, transform.position.z);
        // scroll faster with time
        scroll += 0.001f * Time.deltaTime;
    }
}
