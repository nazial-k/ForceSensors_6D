using UnityEngine;
using UnityEngine.UI;

public class SensorReadings : MonoBehaviour
{
    public Vector3 randomPosition = Vector3.zero;

    public float minX =0f;
    public float maxX =0f;

    public float minY =0f;
    public float maxY =0f;

    public float minZ =0f;
    public float maxZ =0f;

    public static float minForce=-100f;
    public static float maxForce=100f;

    public Vector3 randomForce = Vector3.zero;


    public void GenerateRandomPosition()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        float z = Random.Range(minZ, maxZ);

        randomPosition = new Vector3(x, y, z);
    }

    public void GenerateRandomForce()
    {
        float x = Random.Range(minForce,maxForce);
        float y = Random.Range(minForce,maxForce);
        float z = Random.Range(minForce,maxForce);

        randomForce = new Vector3(x, y, z);
    }


}