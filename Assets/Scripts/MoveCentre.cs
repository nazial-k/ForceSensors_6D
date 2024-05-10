using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCentre : MonoBehaviour
{
    public Vector3 targetPosition; // The position to move towards
    public float speed = 2.0f; // The speed of movement

     void Update()
    {
        // If the static target position is not null, move towards it
        Vector3 senPos = GetComponent<SensorReadings>().randomPosition;
        if (senPos != null)
        {
            targetPosition = senPos;
            // Calculate the distance between the current position and the target position
            float distance = Vector3.Distance(transform.position, targetPosition);

            // If the distance is greater than a small value (e.g., 0.1), move towards the target position
            if (distance > 0.1f)
            {
                // Calculate the new position using Lerp
                Vector3 newPosition = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
                
                // Update the object's position
                transform.position = newPosition;
            }
        }
    }
}
