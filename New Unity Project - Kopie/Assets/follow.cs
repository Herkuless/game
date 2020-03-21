using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target,blau,rot;
    public new Camera camera;

    public float smoothSpeed = 0.125f;
    public float zoomFactor;
    float distance;
    public Vector3 offset;

    void LateUpdate()
    {
        if (blau.position.y > rot.position.y) target = blau;
        else target = rot;
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        smoothedPosition.x = 0;
        transform.position = smoothedPosition;
        //distance = (blau.position - rot.position).magnitude;
        //if (distance>10) camera.orthographicSize = distance * zoomFactor;
    }

    public bool blau_winning()
    {
        if (blau.position.y >= rot.position.y) return true;
        else return false;
    }
    public bool rot_winning()
    {
        if (blau.position.y < rot.position.y) return true;
        else return false;
    }
}
