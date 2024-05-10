using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceUI : MonoBehaviour
{

    public Text forceText;

    public Text forceMag;

    void Update()
    {
        // Get the current force of the sensor
        Vector3 force = GetComponent<SensorReadings>().randomForce;

        // Update the text of the UI Text element
        forceText.text = "Force Vector: " + force.ToString();

        forceMag.text = "Force Magnitude: " + force.magnitude.ToString();
    }
}
