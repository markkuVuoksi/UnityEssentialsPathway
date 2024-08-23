using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The length of a full day in seconds, editable in the Inspector
    public float dayLengthInSeconds = 60.0f;

    // Internal variable to track the rotation speed
    private float rotationSpeed;

    void Start()
    {
        // Calculate the rotation speed based on the length of the day
        // 360 degrees per dayLengthInSeconds
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate the light around the X-axis to simulate the day-night cycle
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}