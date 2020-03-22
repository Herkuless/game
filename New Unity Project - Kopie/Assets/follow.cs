using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform blau,rot;
    public new Camera camera;

    public Vector3 offset;
    public Vector3 target;

    public float smoothSpeed = 0.125f;
    public float zoomFactor;
    public float distance,zoom_distance;

    public string winner;

    void Start() {
        camera.orthographicSize = 10;
    }

    void LateUpdate()
    {
        distance = Mathf.Abs(blau.position.y - rot.position.y);
        zoom_distance = Mathf.Lerp(zoom_distance, distance, 0.5f);
        if(distance < 15) {
          target = (blau.position + rot.position)/2;
          winner = "none";
        }
        else {
          if (blau.position.y > rot.position.y) {
            target = blau.position;
            winner = "blau";
          }
          else {
            target = rot.position;
            winner = "rot";
          }
          Time.timeScale = Mathf.Lerp(Time.timeScale,0.0f,0.05f);
          if(Input.GetButton("Submit")) {
            Application.LoadLevel(Application.loadedLevel);
            Time.timeScale = 1.0f;
          }
        }

        Vector3 desiredPosition = target + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);



        transform.position = smoothedPosition;
        if (distance > 10 && distance < 15) camera.orthographicSize = zoom_distance * zoomFactor;
    }

    public string getWinner(){
        return winner;
    }
}
