using UnityEngine;

public class ArrowColor : MonoBehaviour
{
    // Reference to the Renderer component of the GameObject
    public Renderer objectRenderer1;
    public Renderer objectRenderer2;
    public Renderer objectRenderer3;

    void Start(){
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (objectRenderer1 != null & objectRenderer2 != null & objectRenderer3 != null)
        {
            
            float force = transform.parent.GetComponent<SensorReadings>().randomForce.magnitude;

            //Debug.Log(force);

            float FVal = SensorReadings.maxForce;

            Vector3 maxForce = new Vector3(FVal,FVal,FVal);

            float maxMag = maxForce.magnitude; //check maximum possible force to compare against

            float normalizedMagnitude = Mathf.Clamp01(force / maxMag);

            Color newColor = Color.Lerp(Color.green, Color.red, normalizedMagnitude);

            objectRenderer1.material.color = newColor;
            objectRenderer2.material.color = newColor;
            objectRenderer3.material.color = newColor;

        }
        else
        {
            Debug.LogWarning("Renderer component reference is null!");
        }
    }
}
