using UnityEngine;

public class SensorPos : MonoBehaviour
{
    public static Vector3 randomPosition;

    public void GenerateRandomPosition()
    {
        float x = Random.Range(-100f, 100f);
        float y = Random.Range(-100f, 100f);
        float z = Random.Range(-100f, 100f);

        randomPosition = new Vector3(x, y, z);
    }
}