using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForceGenerator : MonoBehaviour
{
    public static Vector3 randomForce;

    public float rotationSpeed = 5.0f;

    public GameObject Arrow;

    public void GenerateRandomForce()
    {
        float x = Random.Range(-100f, 100f);
        float y = Random.Range(-100f, 100f);
        float z = Random.Range(-100f, 100f);

        randomForce = new Vector3(x, y, z);

        if(!Arrow.activeSelf){
            Arrow.SetActive(true);
        }
    }

    void Update(){
        if(randomForce != Vector3.zero){

                // Calculate the desired rotation based on the direction
                Quaternion targetRotation = Quaternion.LookRotation(randomForce);

                // Gradually rotate towards the desired rotation using Quaternion.Lerp
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    void Start(){
    }
}
