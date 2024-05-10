using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    public GameObject Arrow;

    private float rotationSpeed = 5.0f;

    void Update(){
        Vector3 force = GetComponent<SensorReadings>().randomForce;
        if(force != Vector3.zero){
            
                if(!Arrow.activeSelf){
                    Arrow.SetActive(true);
                }
                // Calculate the desired rotation based on the direction
                Quaternion targetRotation = Quaternion.LookRotation(force);

                // Gradually rotate towards the desired rotation using Quaternion.Lerp
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
