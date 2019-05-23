using UnityEngine;

public class FallowMeNew : MonoBehaviour {
    public Transform Player;
    public Vector3 Setting;
    public float SmoothSpeed = 0.125f;

    private void FixedUpdate()
    {
        Vector3 position = Player.position + Setting;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, position, SmoothSpeed);
        transform.position = SmoothPosition;
    }
}